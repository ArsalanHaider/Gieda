using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GDA
{
    public partial class UserMain : Form
    {
        public int uid;

        public UserMain(int userId)
        {
            InitializeComponent();
            Logic.connection con = new Logic.connection();
            this.uid = userId;
            con.Select("SELECT Userss.userName, UserRoles.role FROM UserRoles INNER JOIN Userss ON Userss.roleId=UserRoles.roleId where userId='" + uid + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                // lblUserName.Text = dt.Rows[0]["userName"].ToString();
                // label6.Text = dt.Rows[0]["role"].ToString();


            }
        }


        private void UserMain_Load(object sender, EventArgs e)
        {
            //label7.Text = DateTime.UtcNow.ToString();

            Home.Dashboard dashboard = new Home.Dashboard(uid);
            dashboard.MdiParent = this;
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();


            foreach (Control control in this.Controls)
            {

                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.White;
                    // 4#
                    break;
                }

            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnExit);
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Gieda Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPlots_Click_1(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnPlots);
            User.PlotView plot = new User.PlotView();
            plot.MdiParent = this;
            plot.StartPosition = FormStartPosition.CenterScreen;
            plot.Show();
        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnReports);

            User.PhaseView Phase = new User.PhaseView();
            Phase.MdiParent = this;
            Phase.StartPosition = FormStartPosition.CenterScreen;
            Phase.Show();
        }

       

        private void btnAllotees_Click_1(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnAllotees);
            User.AllotteeView allottee = new User.AllotteeView();
            //Allottees.AllotteesDetails allottee = new Allottees.AllotteesDetails();
            allottee.MdiParent = this;
            allottee.StartPosition = FormStartPosition.CenterScreen;
            allottee.Show();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {

        }

        private void moveSidePanel_Paint(Control btn)
        {
            moveSidePanel.Top = btn.Top;
            moveSidePanel.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel_Paint(btnHome);
            Home.Dashboard dashboard = new Home.Dashboard(uid);
            dashboard.MdiParent = this;
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
        }
    }
}

