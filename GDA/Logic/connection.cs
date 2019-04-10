using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDA.Logic
{
    class connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public string message;
        public void connections()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gieda;Integrated Security=True");
            con.Open();
        }

        public void Insert(string Query)
        {
            try
            {
                connections();
                cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                message = "";
            }
            catch (Exception ee)
            {

                message = "Please Check your data {0}" + ee.ToString();
            }

            con.Close();
        }
        public void Update(string Query)
        {
            try
            {
                connections();
                cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                message = "";
            }
            catch (Exception ee)
            {

                message = "Please Check your data {0}" + ee.ToString();
            }

            con.Close();
        }
        public void Delete(string SQL)
        {
            try
            {
                connections();
                cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                message = "";
            }
            catch (Exception ee)
            {

                message = "Please Check your data {0}" + ee.ToString();
            }

            con.Close();
        }

        public string Select(string Query)
        {
            try
            {
                connections();
                sda = new SqlDataAdapter(Query, con);
                message = "";

            }
            catch (Exception ee)
            {

                message = "Please Check your data {0}" + ee.ToString();

            }
            return message;
        }


    }
}
