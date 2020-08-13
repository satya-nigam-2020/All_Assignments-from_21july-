using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebDataAccessDemo
{
    public partial class WebDisconnected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QGTOJ74;Initial" +
                " Catalog=JulyDotNet2020;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from EmployeeTbl",
                conn);
            SqlCommand cmd1 = new SqlCommand("select * from BookTable",
               conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);

            DataSet ds = new DataSet();
            da.Fill(ds, "Emp");
            da1.Fill(ds, "BookTable");

            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            GridView2.DataSource = ds.Tables[1];
            GridView2.DataBind();

        }
    }
}