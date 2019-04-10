using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDA.ReportForms
{
    public partial class allotteeStatement : Form
    {
        giedaEntities db;
        Logic.connection con = new Logic.connection();
        int id = 0;
        public allotteeStatement(int allottee_id)
        {
            InitializeComponent();
            id = allottee_id;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void allotteeStatement_Load(object sender, EventArgs e)
        {
            db = new giedaEntities();
            con = new  Logic.connection();
            //ReportDocument rdoc = new ReportDocument();
            //con.dataGet("SELECT  allotee_plots.id,allotee_plots.allottee_id FROM  allotee_plots INNER JOIN allottees ON allotee_plots.allottee_id = allottees.id INNER JOIN  plots ON allotee_plots.plot_id = plots.id");
            //con.dataGet("SELECT id,name, father_name, nic  FROM allottees");
            //DataTable dt = new DataTable();
            //con.sda.Fill(dt);
            //string appPath = Application.StartupPath;
            //string reportPath = @"Reports\CrystalReport1.rpt";
            //string fullPath = Path.Combine(appPath, reportPath);
            //string path = @"C:\Users\shahid\source\repos\gieda\gieda\Reports\CrystalReport1.rpt";
            ////  MessageBox.Show(fullPath);
            //rdoc.Load(path);
            //rdoc.SetDataSource(dt);
            crystalReportViewer1.ReportSource = null;

            //Reports.CrystalReport1 crpt = new Reports.CrystalReport1();
            Report.CrystalReport1 crpt = new Report.CrystalReport1();
            // crpt.SetDataSource(dt);

            var query = db.allottees
                        .Join(db.allotee_plots,
                        c => c.id,
                        cm => cm.allottee_id,
                        (c, cm) => new { allottee = c, allotee_plots = cm })
                        .Select(x => new { x.allottee.id, x.allottee.pds_number, nic = x.allottee.nic.ToString(), x.allottee.name, x.allottee.father_name, x.allottee.address, plot_id = x.allotee_plots.plot_id }).Where(n => n.id == id ).ToList();


            var query2 = db.allottees.Select(c => new
            {
                id = c.id.ToString(),
                name = c.name,
                title = c.nic.ToString(),
                pds = c.pds_number

            }).ToList();
            crpt.Database.Tables["allottees"].SetDataSource(query);
            crpt.Database.Tables["allotee_plots"].SetDataSource(db.allotee_plots.Where(c => c.allottee_id == id).ToList());

            crpt.Database.Tables["plots"].SetDataSource(db.plots.Select(c => new
            {
                id = c.id.ToString(),
                title = c.title
            }).ToList());

            crpt.Database.Tables["allottee_payments"].SetDataSource(db.allottee_payments.Select(c => new
            {
                id = c.id.ToString(),
                title = c.title,
                due_amount = c.due_amount,
                due_date = c.due_date.ToString(),
                amount = c.amount,
                paid_on = c.paid_on.ToString(),
                surcharge = c.surcharge,
                allottee_id = c.allottee_id
            }).Where(n => n.allottee_id == id).ToList());
            crpt.Database.Tables["installment_payments"].SetDataSource(db.installment_payments.Select(c => new
            {
                id = c.id.ToString(),
                title = c.title,
                due_amount = c.due_amount,
                due_date = c.due_date.ToString(),
                amount = c.amount,
                paid_on = c.paid_on.ToString(),
                surcharge = c.surcharge,
                allottee_id = c.allottee_id

            }).Where(n => n.allottee_id == id).ToList());
            con.Select("SELECT sum(due_amount) as due_amount, sum(amount) as paid_amount,sum(surcharge) FROM[dbo].[allottee_payments] where allottee_id = " + id);
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            int total_due_amount = 0;
            int total_paid_amount = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["due_amount"].ToString() != "")
                {
                    total_due_amount = Int32.Parse(row["due_amount"].ToString());
                    total_paid_amount = Int32.Parse(row["paid_amount"].ToString());
                    //  crpt.SetParameterValue("total_due", row["due_amount"].ToString());
                }
            }

            con.Select("SELECT sum(due_amount) as due_amount, sum(amount) as paid_amount,sum(surcharge) FROM[dbo].[installment_payments] where allottee_id = " + id);
            DataTable dt2 = new DataTable();
            con.sda.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                if (row["due_amount"].ToString() != "")
                {
                    total_due_amount += Int32.Parse(row["due_amount"].ToString());
                    total_paid_amount += Int32.Parse(row["paid_amount"].ToString());
                }
                crpt.SetParameterValue("total_due", total_due_amount.ToString());
                crpt.SetParameterValue("total_paid", total_paid_amount);
            }

            var margins = crpt.PrintOptions.PageMargins;

            crystalReportViewer1.ReportSource = crpt;
            crystalReportViewer1.EnableDrillDown = false;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
