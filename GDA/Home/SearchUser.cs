using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDA.User
{
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        Logic.connection con = new Logic.connection();
        void LoadData(string condition)
        {
            try
            {
                con.Select("SELECT userId, name, email, address, userPassword,UserRoles.role, userName, contact, cnic FROM Userss INNER JOIN UserRoles ON Userss.roleId= UserRoles.roleId " + condition + "");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["dduserID"].Value = row["userId"].ToString();
                    dataGridView1.Rows[n].Cells["ddname"].Value = row["name"].ToString();
                    dataGridView1.Rows[n].Cells["ddrole"].Value = row["role"].ToString();
                    dataGridView1.Rows[n].Cells["ddpassword"].Value = row["userPassword"].ToString();
                    dataGridView1.Rows[n].Cells["ddemail"].Value = row["email"].ToString();
                    dataGridView1.Rows[n].Cells["ddaddress"].Value = row["address"].ToString();
                    dataGridView1.Rows[n].Cells["dduserName"].Value = row["userName"].ToString();
                    dataGridView1.Rows[n].Cells["ddcontact"].Value = row["contact"].ToString();
                    dataGridView1.Rows[n].Cells["ddcnic"].Value = row["cnic"].ToString();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.ToString());
            }
        }
        void LoadData()
        {
            try
            {
                con.Select("SELECT userId, name, userPassword,UserRoles.role, email, address, userName, contact, cnic FROM Userss INNER JOIN UserRoles ON Userss.roleId= UserRoles.roleId");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["dduserID"].Value = row["userId"].ToString();
                    //  dataGridView1.Rows[n].Cells["ddlrole"].Value = row["role"].ToString();
                    dataGridView1.Rows[n].Cells["ddname"].Value = row["name"].ToString();
                    dataGridView1.Rows[n].Cells["ddrole"].Value = row["role"].ToString();
                    dataGridView1.Rows[n].Cells["ddpassword"].Value = row["userPassword"].ToString();
                    dataGridView1.Rows[n].Cells["ddemail"].Value = row["email"].ToString();
                    dataGridView1.Rows[n].Cells["ddaddress"].Value = row["address"].ToString();
                    dataGridView1.Rows[n].Cells["dduserName"].Value = row["userName"].ToString();
                    dataGridView1.Rows[n].Cells["ddcontact"].Value = row["contact"].ToString();
                    dataGridView1.Rows[n].Cells["ddcnic"].Value = row["cnic"].ToString();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ddlSearch.SelectedIndex == 0)
            {
                LoadData();
            }
            if (ddlSearch.SelectedIndex == 1)
            {
                LoadData("Where userId='" + txtSearch.Text + "'");
            }
            if (ddlSearch.SelectedIndex == 2)
            {
                LoadData("Where contact='" + txtContact.Text + "'");
            }
            if (ddlSearch.SelectedIndex == 3)
            {
                LoadData("Where cnic='" + txtCnic.Text + "'");
            }
        }

        private void Search_load(object sender, EventArgs e)
        {
            Search();
            ddlSearch.SelectedIndex = 0;
            txtSearch.Visible = false;
            LoadData();
        }

        private void ddlSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSearch.SelectedIndex == 0)
            {
                txtSearch.Visible = false;
                txtContact.Visible = false;
                txtCnic.Visible = false;
            }
            if (ddlSearch.SelectedIndex == 1)
            {
                txtSearch.Visible = true;
                txtSearch.Clear();
                txtContact.Visible = false;
                txtCnic.Visible = false;
            }
            if (ddlSearch.SelectedIndex == 2)
            {
                txtSearch.Visible = false;
                txtContact.Visible = true;
                txtContact.Clear();
                txtCnic.Visible = false;
            }
            if (ddlSearch.SelectedIndex == 3)
            {
                txtSearch.Visible = false;
                txtContact.Visible = false;
                txtCnic.Visible = true;
                txtCnic.Clear();

            }

        }

        private DataGridView dgView;
        private DataGridViewTextBoxColumn dgViewColumn1;
        private DataGridViewTextBoxColumn dgViewColumn2;

        void Search()
        {
            dgView = new DataGridView();
            dgViewColumn1 = new DataGridViewTextBoxColumn();
            dgViewColumn2 = new DataGridViewTextBoxColumn();
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgViewColumn1, dgViewColumn2 });
            this.dgView.Name = "dgview";
            dgView.Visible = false;
            this.dgViewColumn1.Visible = false;
            this.dgViewColumn2.Visible = false;
            this.dgView.AllowUserToAddRows = false;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Controls.Add(dgView);
            this.dgView.ReadOnly = true;
            dgView.BringToFront();

        }

        void Search(int LX, int LY, int DW, int DH, string ColName, String ColSize)
        {
            this.dgView.Location = new System.Drawing.Point(LX, LY);
            this.dgView.Size = new System.Drawing.Size(DW, DH);

            string[] Clsize = ColSize.Split(',');
            for (int i = 0; i < Clsize.Length; i++)
            {
                if (int.Parse(Clsize[i]) != 0)
                {
                    dgView.Columns[i].Width = int.Parse(Clsize[i]);

                }
                else
                {
                    dgView.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

                }
            }
            string[] ClName = ColName.Split(',');

            for (int i = 0; i < ClName.Length; i++)
            {
                this.dgView.Columns[i].HeaderText = ClName[i];
                this.dgView.Columns[i].Visible = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "Enter value...")
                txtSearch.Text = "";
        }
    }
}
