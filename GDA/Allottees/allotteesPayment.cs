using System;
using System.Linq;
using System.Windows.Forms;

namespace GDA.Allottees
{
    public partial class allotteesPayment : Form
    {
        public allotteesPayment(int allottee_id)
        {
            id = allottee_id;
            InitializeComponent();
        }
        giedaEntities db;
        int id = 0;
        private void otherPayment_Click(object sender, EventArgs e)
        {
            try
            {
                db = new giedaEntities();
                var allottee_Payment = new allottee_payments()
                {
                    allottee_id = id,
                    title = txtTitle.Text,
                    description = txtDescription.Text,
                    amount = Int32.Parse(txtAmount.Text),
                    surcharge = Int32.Parse(txtSurcharge.Text),
                    paid_on = DateTime.Parse(PaidOnDate.Value.ToShortDateString()),
                    due_amount = Int32.Parse(txtDueAmount.Text),
                    due_date = DateTime.Parse(dueDate.Value.ToShortDateString()),
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now

                };

                db.allottee_payments.Add(allottee_Payment);
                db.SaveChanges();

                MessageBox.Show("Record Inserted");
            }

            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.ToString());
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                db = new giedaEntities();
                var installment_Payment = new installment_payments()
                {
                    allottee_id = id,
                    title = "Installment ",
                    installment_id = Int32.Parse(ddlInstallment.SelectedValue.ToString()),
                    amount = Int32.Parse(ddlAmountPaid.Text),
                    surcharge = Int32.Parse(ddlSurcharge.Text),
                    paid_on = DateTime.Parse(ddlPaidDate.Value.ToShortDateString()),
                    due_amount = Int32.Parse(ddlDueAmount.Text),
                    due_date = DateTime.Parse(ddlDueDate.Value.ToShortDateString()),
                    total_amount = (Int32.Parse(ddlDueAmount.Text) + Int32.Parse(ddlSurcharge.Text)),
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now

                };

                db.installment_payments.Add(installment_Payment);
                db.SaveChanges();

                MessageBox.Show("Record Inserted");
            }

            catch (Exception ee)
            {
                MessageBox.Show("Error: " + ee.ToString());
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Paymemt_load(object sender, EventArgs e)
        {
            db = new giedaEntities(); installmentBindingSource.DataSource = db.installments.ToList();

        }
    }
}
