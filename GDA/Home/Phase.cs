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
    public partial class Phase : Form
    {
        public Phase()
        {
            InitializeComponent();
        }
        Logic.connection con = new Logic.connection();
        string query = "Select * From phases ";
        
        
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

                    dataGridView1.Rows[n].Cells["name"].Value = row["name"].ToString();
                    dataGridView1.Rows[n].Cells["description"].Value = row["description"].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[4];
            if (cb.Value != null)
            {
                var comboId = cb.Value.ToString();
                var row_id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

                if (comboId == "Update")
                {


                    var p = new Props();
                    p.id = Int32.Parse(row_id);
                    GDA.Phases.EditPhase edit = new GDA.Phases.EditPhase(p.id);
                    edit.Show();




                }
                else if (comboId == "Delete")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            con.Delete("Delete From phases where id=" + Int32.Parse(row_id) + "");
                            LoadData();

                            MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                // do stuff

            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Select * from phases where  name = '" + searchBox.Text + "'";
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            GDA.Phases.AddPhases cc = new GDA.Phases.AddPhases();
            cc.Show();

        }

        private void Phase_Load(object sender, EventArgs e)
        {
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView1.CurrentCellDirtyStateChanged += new EventHandler(current_Cell_State);
            LoadData();
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

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                query = "Select * From phases ";
                LoadData();
            }
        }

        private void MouseClick_1(object sender, MouseEventArgs e)
        {
            if (searchBox.Text == "Search by Name")

                searchBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class Props
        {
            public int id = 2312312;

            public Int32 Id { get { return id; } set { id = value; } }
        }
    }
}
