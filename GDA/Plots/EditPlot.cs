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
    public partial class EditPlot : Form
    {
        int id = 0;
        public EditPlot(int plot_id)
        {
            InitializeComponent();
            id = plot_id;

        }
        Logic.connection con = new Logic.connection();
        giedaEntities db;
       
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE plots SET   title ='" + title_textBox.Text + "', size ='" + size_textBox.Text + "', description ='" + description_textBox.Text + "', down_payment ='" + Int32.Parse(downPayment_textBox.Text) + "', form_fee ='" + Int32.Parse(formFee_textBox.Text) + "', total_price ='" + Int32.Parse(price_textBox.Text) + "', installments ='" + installment_textBox.Text + "', quantity ='" + Int32.Parse(quantity_textBox.Text) + "', phase_id ='" + Int32.Parse(phaseComboxBox.SelectedValue.ToString()) + "' where id= " + id;

            try
            {
                con.Update(query);

                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error !!" + ex.Message);
            }
        }

        private void EditPlot_Load(object sender, EventArgs e)
        {
            try
            {
                db = new giedaEntities();
                phaseBindingSource.DataSource = db.phases.ToList();
                con.Select("SELECT *  From plots where id =" + id + "");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    title_textBox.Text = row["title"].ToString();
                    description_textBox.Text = row["description"].ToString();
                    size_textBox.Text = row["size"].ToString();
                    downPayment_textBox.Text = row["down_payment"].ToString();
                    formFee_textBox.Text = row["form_Fee"].ToString();
                    installment_textBox.Text = row["installments"].ToString();
                    quantity_textBox.Text = row["quantity"].ToString();
                    price_textBox.Text = row["total_price"].ToString();
                    phaseComboxBox.SelectedValue = Int32.Parse(row["phase_id"].ToString());



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
