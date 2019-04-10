using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDA.Plots
{
    public partial class AddPlots : Form
    {
        giedaEntities db;

        public AddPlots()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new giedaEntities();
            try
            {

                var plt = new plot()
                {
                    title = title_textBox.Text,
                    size = size_textBox.Text,
                    description = description_textBox.Text,
                    down_payment = Int32.Parse(downPayment_textBox.Text),
                    form_fee = formFee_textBox.Text,
                    total_price = price_textBox.Text,
                    quantity = Int32.Parse(quantity_textBox.Text),
                    installments = installment_textBox.Text,
                    phase_id = Int32.Parse(phaseComboxBox.SelectedValue.ToString()),
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now

                };

                db.plots.Add(plt);
                db.SaveChanges();

                MessageBox.Show("Record has been successfully added");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!! " + ex.Message);
            }
        }

        private void AddPlots_Load(object sender, EventArgs e)
        {
            db = new giedaEntities();
            phaseBindingSource.DataSource = db.phases.ToList();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
