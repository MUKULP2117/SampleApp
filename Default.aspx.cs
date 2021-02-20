using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sample5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable dt = getdt("select * from tbl_usr");
            grdusr.DataSource = dt;
            grdusr.DataBind();
        }

        public DataTable getdt(string qry)
        {
            string con = "server=sql12.freesqldatabase.com;uid=sql12394243;pwd=a7iYFPcsQk;database=sql12394243";
            DataTable dt = new DataTable();
            try
            {
                MySqlConnection cn = new MySqlConnection(con);
                cn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(qry, cn);
                da.Fill(dt);
                cn.Close();
            }
            catch { }
            return dt;
        }
    }
}