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
    public partial class AddPhases : Form
    {
        public AddPhases()
        {
            InitializeComponent();
        }
        giedaEntities db;

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db = new giedaEntities();
                var myPhase = new phase()
                {
                    name = name.Text,
                    title = title.Text,
                    description = description.Text,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now

                };
                db.phases.Add(myPhase);
                db.SaveChanges();

                MessageBox.Show("Record Added Successfully");


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !! " + ex.Message);
            }
        }
    }
    
}
