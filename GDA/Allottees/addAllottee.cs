using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GDA.Allottees
{
    public partial class addAllottee : Form
    {
        giedaEntities db;
        Logic.connection con = new Logic.connection();
        string[] doc_file_name = new string[1];
        string[] doc_file_path = new string[1];
        string file_name = "";
        string file_path = "";

        public int uid;
        public addAllottee(int userId)
        {
            this.uid = userId;
            InitializeComponent();
            doc_file_name[0] = "";
            doc_file_path[0] = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (doc_file_name[0] != "" && file_name != "")
            {
                try
                {
                    string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\docs\"; // <---
                    string appPath_profile = Path.GetDirectoryName(Application.ExecutablePath) + @"\allotteeProfile\";
                    string ext = Path.GetExtension(file_name);
                    string pic_name = Guid.NewGuid().ToString() + ext;


                    try
                    {

                        db = new giedaEntities();
                        long num;
                        string nic = nic_textBox.Text;
                        num = long.Parse(nic);
                        var addAllottee = new allottee()
                        {
                            name = txtName.Text,
                            father_name = txtFname.Text,
                            address = txtAddress.Text,
                            city = txtCity.Text,
                            province = txtProvince.Text,
                            domicile = txtDomicile.Text,
                            pds_number = txtPdsNumber.Text,
                            nic = num,
                            af_number = txtAfNumber.Text,
                            picture = pic_name,
                            created_at = DateTime.Now,
                            updated_at = DateTime.Now

                        };
                        db.allottees.Add(addAllottee);

                        db.SaveChanges();
                        File.Copy(file_path, appPath_profile + pic_name);
                        int id = addAllottee.id;
                        for (int i = 0; i < doc_file_path.Length; i++)
                        {
                            string extt = Path.GetExtension(doc_file_name[i]);
                            string doc_name = Guid.NewGuid().ToString() + ext;
                            db = new giedaEntities();
                            allottee_documents allotteeDocuments = new allottee_documents()
                            {
                                title = "Allottee Document",
                                document = doc_name,
                                allotee_id = id,
                                created_at = DateTime.Now,
                                updated_at = DateTime.Now
                            };

                            db.allottee_documents.Add(allotteeDocuments);
                            db.SaveChanges();
                        }
                        db = new giedaEntities();
                        var allotteePlot = new allotee_plots()
                        {
                            allottee_id = id,
                            plot_id = Int32.Parse(txtPlot.SelectedValue.ToString())
                        };
                        db.allotee_plots.Add(allotteePlot);
                        db.SaveChanges();




                        MessageBox.Show("Record inserted Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid action " + ex.Message);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Invalid action " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kindly Upload image or documents");
            }
        }
        private void upload_documents_Click(object sender, EventArgs e)
        {
            try
            {
                uploadMultipleFiles();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid action " + ex.Message);
            }
        }

        public void uploadMultipleFiles()
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\profile\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }                                                                                    // <---

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                //String path = dialog.FileName; // get     name of file

                try
                {
                    int arraylength = dialog.FileNames.ToList().Count();
                    doc_file_path = new string[arraylength];
                    doc_file_name = new string[arraylength];

                    int i = 0;
                    dialog.FileNames.ToList().ForEach(file =>
                    {

                        // messagebox.show(file.count().tostring());
                        doc_file_path[i] = dialog.FileNames[i];
                        doc_file_name[i] = dialog.SafeFileNames[i];

                        //messagebox.show(file.tostring());
                        i++;
                    });

                    // picProduct.Image = new Bitmap(dialog.OpenFile());
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
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
                                                    // picProduct.Image = new Bitmap(dialog.OpenFile());
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
        }

        private void addAllottee_Load(object sender, EventArgs e)
        {
            db = new giedaEntities();
            plotBindingSource.DataSource = db.plots.ToList();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            try
            {
                uploadSingleFile();
                string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\allotteeProfile\";

                if (file_name != "")
                {
                    pictureBox1.Image = Image.FromFile(file_path);
                }
                else
                {
                    MessageBox.Show("No file selected");
                }
                //File.Copy(file_path, appPath + file_name);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kindly select an valid image" + ex.Message);
            }
        }

        private void upload_documents_Click_1(object sender, EventArgs e)
        {
            try
            {
                uploadMultipleFiles();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid action " + ex.Message);
            }
        }


    }
}
