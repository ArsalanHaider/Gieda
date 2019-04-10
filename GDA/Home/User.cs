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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (ifUserNameExists(txtUsername.Text))
                {
                    MessageBox.Show("User Name Already Exists");
                }
                else
                {
                    try
                    {

                        con.Insert("INSERT INTO Users(name, email, userName, userPassword, roleId, cnic,contact,userProfileCreate, address)VALUES  ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + (int)ddlRole.SelectedValue + "','" + txtCnic.Text + "','" + txtContact.Text + "','" + DateTime.Now.ToString("MM-dd-yyyy") + "','" + txtAddress.Text + "')");
                        MessageBox.Show("record saved successfully");
                        ClearData();
                        LoadData();
                        TextBoxPlaceHolders();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Error Detected: {0} ", ee.ToString());

                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.Update("UPDATE [userss] SET name='" + txtName.Text + "', email='" + txtEmail.Text + "', userName='" + txtUsername.Text + "',userPassword='" + txtPassword.Text + "',cnic ='" + txtCnic.Text + "',contact ='" + txtContact.Text + "',address ='" + txtAddress.Text + "' where userName='" + txtUsername.Text + "'");
                MessageBox.Show("Updated Successfully", "Message", MessageBoxButtons.OK);
                LoadData();
                ClearData();
                TextBoxPlaceHolders();
                btnRegister.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    con.Delete("Delete From [Userss] where userName='" + txtUsername.Text + "'");
                    MessageBox.Show("Deleted Successfully", "Message", MessageBoxButtons.OK);
                    ClearData();
                    LoadData();
                    TextBoxPlaceHolders();

                    btnRegister.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }

                catch (Exception ee)
                {
                    MessageBox.Show("Error Detected: {0} ", ee.ToString());

                }
            }
        }

        private void user_load(object sender, EventArgs e)
        {
            this.ActiveControl = txtName;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            LoadData();
        }

        ErrorProvider e1 = new ErrorProvider();
        private bool validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                e1.Clear();
                e1.SetError(txtName, "Full Name Required");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e1.Clear();
                e1.SetError(txtUsername, "User Name Required");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e1.Clear();
                e1.SetError(txtPassword, "Password Required");
            }
            else if (txtPassword.Text.Length < 4)
            {
                e1.Clear();
                e1.SetError(txtPassword, "Minimum length of Password Required is 4");

            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e1.Clear();
                e1.SetError(txtEmail, "Email Required");
            }
            else if (ddlRole.SelectedIndex == -1)
            {
                e1.Clear();
                e1.SetError(ddlRole, "Select Role");
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e1.Clear();
                e1.SetError(txtAddress, "Address Required");
            }
            else if (string.IsNullOrEmpty(txtContact.Text))
            {
                e1.Clear();
                e1.SetError(txtContact, "Contact Required");
            }
            else if (string.IsNullOrEmpty(txtCnic.Text))
            {
                e1.Clear();
                e1.SetError(txtCnic, "CNIC Required");
            }
            else if (txtCnic.Text.Length < 13 || txtCnic.Text.Length > 13)
            {
                e1.Clear();
                e1.SetError(txtPassword, "CNIC Required is of 13 length");

            }

            else
            {
                e1.Clear();
                result = true;
            }
            return result;
        }
        Logic.connection con = new Logic.connection();
        private bool ifUserNameExists(string UserName)
        {
            con.Select("Select 1 From [Userss] WHERE [userName]='" + UserName + "'");

            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void ClearData()
        {
            //This line clears the data
            txtName.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtCnic.Clear();
            txtContact.Clear();
            ddlRole.SelectedIndex = -1;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnRegister.Enabled = true;
            DateTime timeRegistered = DateTime.Now;

        }
        private void TextBoxPlaceHolders()
        {
            txtAddress.Text = "Address";
            txtCnic.Text = "Cnic";
            txtContact.Text = "Contact number";
            txtEmail.Text = "Email";
            txtName.Text = "Full name";
            txtPassword.Text = "Password";
            txtUsername.Text = "User name";

        }

        private void MouseClick1(object sender, MouseEventArgs e)
        {

            if (txtEmail.Text == "Email")
                txtEmail.Text = "";
        }

        private void MouseClick2(object sender, MouseEventArgs e)
        {
            if (txtAddress.Text == "Address")
                txtAddress.Text = "";
        }

        private void MouseClick3(object sender, MouseEventArgs e)
        {
            if (txtCnic.Text == "Cnic")
                txtCnic.Text = "";
        }

        private void MouseClick4(object sender, MouseEventArgs e)
        {
            if (txtContact.Text == "Contact number")
                txtContact.Text = "";
        }

        private void MouseClick5(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "User name")

                txtUsername.Text = "";
        }

        private void MouseClick6(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Text = "";
        }

        private void MouseClick11(object sender, MouseEventArgs e)
        {
            if (txtName.Text == "Full name")
                txtName.Text = "";
        }

        private void txtName_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.Text.Length > 0)
                {
                    txtUsername.Focus();
                }
                else
                {
                    txtName.Focus();
                }
            }
        }
        private void LoadData()
        {
            con.Select("SELECT Userss.userId, Userss.userName,Userss.userPassword, Userss.name, Userss.address, Userss.cnic, Userss.contact, Userss.email, UserRoles.role  FROM Userss INNER JOIN UserRoles ON Userss.roleId = UserRoles.roleId");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["dduserID"].Value = n + 1;
                dataGridView1.Rows[n].Cells["ddrole"].Value = row["role"].ToString();
                dataGridView1.Rows[n].Cells["ddname"].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells["ddemail"].Value = row["email"].ToString();
                dataGridView1.Rows[n].Cells["ddaddress"].Value = row["address"].ToString();
                dataGridView1.Rows[n].Cells["dduserName"].Value = row["userName"].ToString();
                dataGridView1.Rows[n].Cells["ddcontact"].Value = row["contact"].ToString();
                dataGridView1.Rows[n].Cells["ddcnic"].Value = row["cnic"].ToString();

                dataGridView1.Rows[n].Cells["ddpassword"].Value = row["userPassword"].ToString();



            }

        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //value will be transfered to textboxes

                //label1.Text = dataGridView1.SelectedRows[0].Cells["dduserID"].Value.ToString();

                txtName.Text = dataGridView1.SelectedRows[0].Cells["ddname"].Value.ToString();
                txtUsername.Text = dataGridView1.SelectedRows[0].Cells["dduserName"].Value.ToString();
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells["ddemail"].Value.ToString();
                txtAddress.Text = dataGridView1.SelectedRows[0].Cells["ddaddress"].Value.ToString();
                txtContact.Text = dataGridView1.SelectedRows[0].Cells["ddcontact"].Value.ToString();
                txtCnic.Text = dataGridView1.SelectedRows[0].Cells["ddcnic"].Value.ToString();
                ddlRole.Text = dataGridView1.SelectedRows[0].Cells["ddrole"].Value.ToString();
                txtPassword.Text = dataGridView1.SelectedRows[0].Cells["ddpassword"].Value.ToString();

                btnRegister.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                //    txtPassword.ReadOnly = true;
            }
            catch (Exception)

            {
                MessageBox.Show("Error Detected: Please click on filled row ");

            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GDA.User.SearchUser cc = new GDA.User.SearchUser();
            cc.Show();
        }

        private void txtCnic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
