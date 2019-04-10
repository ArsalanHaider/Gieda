using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace GDA.User
{
    public partial class AllotteeView : Form
    {
        giedaEntities db;
        Logic.connection con = new Logic.connection();
        string query = "SELECT  allottees.id,allottees.address, allottees.name,allottees.father_name,allottees.nic,allottees.pds_number, plots.title as title FROM  allotee_plots INNER JOIN allottees ON allotee_plots.allottee_id = allottees.id INNER JOIN  plots ON allotee_plots.plot_id = plots.id ORDER BY allottees.id ";

        int selected_row = 0;
        public AllotteeView()
        {
            InitializeComponent();
        }


        private void gridview1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Allottee_load(object sender, EventArgs e)
        {
            try
            {
                txtSearch.ReadOnly = true;
                dataGridView1.CellValueChanged +=
                new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
                dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(current_Cell_State);
                db = new giedaEntities();
                dataupdateBindingSource.DataSource = db.data_update.ToList();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ddlSort.SelectedText = "Sort by ";
                loadData();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.ToString());
            }
        }

        public void loadData(string orderby = "ASC")
        {
            try
            {
                con = new Logic.connection();
                con.Select(query + " " + orderby);
                //  con.dataGet("SELECT * FROM allottees");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    //dataGridView1.Rows[n].Cells["ddempId"].Value = n + 1;
                    dataGridView1.Rows[n].Cells["id"].Value = row["id"].ToString();

                    dataGridView1.Rows[n].Cells["name"].Value = row["name"].ToString();
                    //dataGridView1.Rows[n].Cells["dddob"].Value = Convert.ToDateTime(row["dob"].ToString()).ToString("dd/MM/yyyy");

                    dataGridView1.Rows[n].Cells["fatherName"].Value = row["pds_number"].ToString();
                    dataGridView1.Rows[n].Cells["address"].Value = row["address"].ToString();

                    dataGridView1.Rows[n].Cells["title"].Value = row["title"].ToString();
                    //dataGridView1.Rows[n].Cells["province"].Value = row["province"].ToString();

                    //dataGridView1.Rows[n].Cells["domicile"].Value = row["domicile"].ToString();
                    //dataGridView1.Rows[n].Cells["ddFilename"].Value = row["fileName"].ToString();


                }
            }

            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.ToString());
            }

        }
        private void Gridview1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string test = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

                int curId = Int32.Parse(test);
                selected_row = curId;
                if (curId >= 0)
                {
                    //  dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red;
                    // MessageBox.Show(test);
                }


            }


            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.ToString());
            }
        }
        private void current_Cell_State(object sender, EventArgs e)
        {
            if (this.dataGridView1.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[5];
            if (cb.Value != null)
            {
                var comboId = cb.Value.ToString();
                var row_id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

                if (comboId == "Update")
                {

                    MessageBox.Show("Only admin can make changes");




                }
                else if (comboId == "Delete")
                {
                    MessageBox.Show("Only admin can make changes");
                }
                else if (comboId == "Account Statement")
                {
                    this.Hide();
                    ReportForms.allotteeStatement repForm = new ReportForms.allotteeStatement(Int32.Parse(row_id));
                    repForm.Show();
                    this.Close();

                }
                else if (comboId == "Add Payment")
                {

                    MessageBox.Show("Only admin can make changes");


                }
                else if (comboId == "Documents")
                {

                    this.Hide();
                    //  int id = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString());
                    Allottees.scannedDocs cc = new Allottees.scannedDocs(Int32.Parse(row_id));
                    cc.Show();
                    this.Close();

                }
                // do stuff

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSort.SelectedIndex == 0)
            {
                loadData("ASC");
            }
            else if (ddlSort.SelectedIndex == 1)
            {
                loadData("DESC");
            }
        }

        private void ddlSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSearch.ReadOnly = false;
                con = new Logic.connection();

                if (ddlSearch.SelectedIndex == 0)
                {
                    string allottee_id = txtSearch.Text;
                    if (Regex.Matches(txtSearch.Text, @"[a-zA-Z]").Count > 0)
                    {
                        allottee_id = "0";
                    }
                    if (txtSearch.Text == "")
                    {
                        query = "SELECT  allottees.id,allottees.address, allottees.name,allottees.father_name,allottees.nic,allottees.pds_number, plots.title as title FROM  allotee_plots INNER JOIN allottees ON allotee_plots.allottee_id = allottees.id INNER JOIN  plots ON allotee_plots.plot_id = plots.id ORDER BY allottees.id ";

                    }
                    else
                    {
                        query = "SELECT  allottees.id,allottees.address, allottees.name,allottees.father_name,allottees.nic,allottees.pds_number, plots.title as title FROM  allotee_plots " +
                           "INNER JOIN allottees ON allotee_plots.allottee_id = allottees.id " +
                           "INNER JOIN  plots ON allotee_plots.plot_id = plots.id where allottees.name = '" + txtSearch.Text + "' OR allottees.id =" + allottee_id + " ORDER BY allottees.id";

                    }

                }
                else if (ddlSearch.SelectedIndex == 1)
                {
                    query = "SELECT  allottees.id,allottees.address, allottees.name,allottees.father_name,allottees.nic,allottees.pds_number, plots.title as title FROM  allotee_plots " +
                        "INNER JOIN allottees ON allotee_plots.allottee_id = allottees.id " +
                        "INNER JOIN  plots ON allotee_plots.plot_id = plots.id where allottees.pds_number = '" + txtSearch.Text + "' ORDER BY allottees.id";




                }
            }

            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.ToString());
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}


