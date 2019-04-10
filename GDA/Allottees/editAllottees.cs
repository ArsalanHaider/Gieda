using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GDA.Allottees
{
    public partial class editAllottees : Form
    {
        public editAllottees(int allottee_id)
        {
            InitializeComponent();
            id = allottee_id;
        }
        string file_name = "";
        string file_path = "";
        int id = 0;
        giedaEntities db;
        Logic.connection con = new Logic.connection();
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            uploadSingleFile();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                db = new giedaEntities();
                con = new Logic.connection();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string ext = Path.GetExtension(file_name);
                    string pic_name = Guid.NewGuid().ToString() + ext;
                    try
                    {
                        con.Update("UPDATE  allottees SET  name ='" + txtName.Text + "', father_name ='" + txtFname.Text + "', address ='" + txtAddress.Text + "', city ='" + txtCity.Text + "', province ='" + txtProvince.Text + "', domicile ='" + txtDomicile.Text + "', pds_number ='" + txtPdsNumber.Text + "',nic =" + long.Parse(txtNic.Text) + ", af_number ='" + txtAfNumber.Text + "',picture = '" + pic_name + "' where id=" + id);
                        string appPath_profile = Path.GetDirectoryName(Application.ExecutablePath) + @"\allotteeProfile\";
                        // con.Update("Update [allotee_plots] SET plot_id=" + Int32.Parse(plotComboxBox.SelectedValue.ToString()) + " where allottee_id=" + id);
                        File.Copy(file_path, appPath_profile + pic_name);
                        MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error! " + ex.Message);
                    }
                }
            }

            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.ToString());
            }
        }

        private void editAllottees_Load(object sender, EventArgs e)
        {
            db = new giedaEntities();
            plotBindingSource.DataSource = db.plots.ToList();
            //name_textBox.Text= p;
            try
            {
                con.Select("SELECT  allottees.*,plots.id as plot_id, plots.title as title FROM  allotee_plots " +
                    "INNER JOIN allottees ON allotee_plots.allottee_id = allottees.id INNER JOIN  plots ON allotee_plots.plot_id = plots.id " +
                    "where allottees.id=" + id + "");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    txtName.Text = row["name"].ToString();
                    txtFname.Text = row["father_name"].ToString();
                    txtAddress.Text = row["address"].ToString();
                    txtCity.Text = row["city"].ToString();
                    txtDomicile.Text = row["domicile"].ToString();
                    txtNic.Text = row["nic"].ToString();
                    txtProvince.Text = row["province"].ToString();
                    txtAfNumber.Text = row["af_number"].ToString();
                    txtPdsNumber.Text = row["pds_number"].ToString();
                    ddlPlot.SelectedValue = Int32.Parse(row["plot_id"].ToString());
                    string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\allotteeProfile\";
                    pictureBox1.Image = Image.FromFile(appPath + row["picture"].ToString());

                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }
        public void uploadSingleFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\allotteeProfile\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {


                try
                {
                    file_name = dialog.SafeFileName;   // <---
                    file_path = dialog.FileName;    // <---
                                                    // <---
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
        }
    }
}
