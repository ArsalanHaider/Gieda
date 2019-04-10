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
    public partial class Dashboard : Form
    {
        Logic.connection con = new Logic.connection();
        public int uid;

        public Dashboard(int userId)
        {
            InitializeComponent();
            this.uid = userId;
        }

        public void UserDetails()
        {
            con.Select(" Select name,userName,cnic,email from Userss where userId='"+uid+"'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblname.Text = dt.Rows[0]["name"].ToString();
                lblusername.Text = dt.Rows[0]["userName"].ToString();
                lblCnic.Text = dt.Rows[0]["cnic"].ToString();
                lblemail.Text = dt.Rows[0]["email"].ToString();

            }
        }

        public void chart()
        {
            chart1.Titles.Add("Pie Chart");
            chart1.Series["s1"].Points.AddXY("Total Phases", lblPhases.Text);
            chart1.Series["s1"].Points.AddXY("Total Plots", lblTotalPlots.Text);
            chart1.Series["s1"].Points.AddXY("Total Allottees", lblTotalAllottees.Text);
        }
        private void CountUsers()
        {
            con.Select(" Select Count(userid) from Userss");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblTotalUsers.Text = dt.Rows[0][0].ToString();
            }

        }
        private void CountAllottee()
        {
            con.Select(" Select Count(id) from allottees");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblTotalAllottees.Text = dt.Rows[0][0].ToString();
            }

        }

        private void CountPds()
        {
            con.Select("Select Count(pds_number)from allottees");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblPds.Text = dt.Rows[0][0].ToString();
            }
        }

        private void CountPhases()
        {
            con.Select(" Select Count(id) from phases");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblPhases.Text = dt.Rows[0][0].ToString();
            }

        }
        private void CountPlots()
        {
            con.Select(" Select SUM(quantity) from plots");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblTotalPlots.Text = dt.Rows[0][0].ToString();
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UserDetails();
            CountUsers();
            CountPds();
            CountPhases();
            CountPlots();
            CountAllottee();
            chart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
