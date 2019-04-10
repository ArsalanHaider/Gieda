using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDA.Phases
{
    public partial class EditPhase : Form
    {
        Logic.connection con = new Logic.connection();
        giedaEntities db;
        int id = 0;
        public EditPhase(int phase_id)
        {
            InitializeComponent();
            id = phase_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "UPDATE   phases SET   name ='" + nameBox.Text + "', title ='" + titleBox.Text + "', description ='" + descriptionBox.Text + "' Where id=" + id;
                con.Update(query);

                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void EditPhase_Load(object sender, EventArgs e)
        {
            try
            {
                con.Select("SELECT *  From phases where id =" + id + "");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    nameBox.Text = row["name"].ToString();
                    titleBox.Text = row["title"].ToString();
                    descriptionBox.Text = row["description"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!! " + ex.Message);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
