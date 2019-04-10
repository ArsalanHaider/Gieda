using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDA.Home
{
    public partial class Plot : Form
    {
        giedaEntities db;
        Logic.connection con = new Logic.connection();
        string query = "Select * From plots ";
        
        public Plot()
        {
            InitializeComponent();
        }

        private void Plot_load(object sender, EventArgs e)
        {
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(current_Cell_State);
            LoadData();
        }

        private void current_Cell_State(object sender, EventArgs e)
        {
            if (this.dataGridView1.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        public void LoadData(string orderBy = "ASC")
        {
            try
            {
                con = new Logic.connection();
                string full_query = query + "  ORDER BY id " + orderBy;
                con.Select(full_query);
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    //dataGridView1.Rows[n].Cells["ddempId"].Value = n + 1;
                    dataGridView1.Rows[n].Cells["id"].Value = row["id"].ToString();

                    dataGridView1.Rows[n].Cells["title"].Value = row["title"].ToString();
                    //dataGridView1.Rows[n].Cells["dddob"].Value = Convert.ToDateTime(row["dob"].ToString()).ToString("dd/MM/yyyy");

                    dataGridView1.Rows[n].Cells["size"].Value = row["size"].ToString();
                    dataGridView1.Rows[n].Cells["description"].Value = row["description"].ToString();

                    dataGridView1.Rows[n].Cells["quantity"].Value = row["quantity"].ToString();
                    //dataGridView1.Rows[n].Cells["province"].Value = row["province"].ToString();

                    //dataGridView1.Rows[n].Cells["domicile"].Value = row["domicile"].ToString();
                    //dataGridView1.Rows[n].Cells["ddFilename"].Value = row["fileName"].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


                   var p = new Props();
                   p.id = Int32.Parse(row_id);
                   Plots.EditPlot edit = new Plots.EditPlot(p.id);
                   edit.Show();




                }
                else if (comboId == "Delete")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                           
                            con.Delete("Delete From plots where id=" + Int32.Parse(row_id) + "");
                            LoadData();

                            MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (comboId == "Account Statement")
                {
                    // this.Hide();
                   // ReportForms.allotteeStatement repForm = new ReportForms.allotteeStatement(Int32.Parse(row_id));
                   // repForm.Show();
                }

                // do stuff

            }
        }

        private void MouseClick1(object sender, MouseEventArgs e)
        {
            if (searchBox.Text == "Search by size")

                searchBox.Text = "";
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Select * from plots where  size = '" + searchBox.Text + "'";
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                query = "Select * From plots ";
                LoadData();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                LoadData("ASC");
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                LoadData("DESC");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Plots.AddPlots addPlots = new Plots.AddPlots();
            addPlots.Show();
           
        }
        public class Props
        {
            public int id = 2312312;

            public Int32 Id { get { return id; } set { id = value; } }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
