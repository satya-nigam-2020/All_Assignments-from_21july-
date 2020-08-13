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

    public partial class ConnectedObjects : System.Web.UI.Page
    {

        // 1. Connection Object

       
       SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QGTOJ74;Initial Catalog=JulyDotNet2020;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
       


        public void ShowGrid()
        {

            conn.Open();

            cmd = new SqlCommand("select * from EmployeeTbl", conn);


            // 3. Data Reader Object

            dr = cmd.ExecuteReader();

            DataTable dt = new DataTable(); //Empty Data Table

            dt.Load(dr);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            dr.Close();
            conn.Close();

            

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            //Open the object first
            if (!IsPostBack)
            {

                ShowGrid();
            }
           
            



            //SqlConnection c = new SqlConnection();

            // 2. Commond Object




            //while (dr.Read()) 
            //{
            //    // DropDownList1.DataSource = dr;
            //    GridView1.DataSource = dr;
            // //   DropDownList1.DataSource = dr[1];
            //    DropDownList1.DataTextField = "empName";
            //   // DropDownList1.DataSource = dr;

            //    GridView1.DataBind();
            //    //DropDownList1.DataSource = dr[1];


            //    //DropDownList1.DataTextField = "empName";
            //    //DropDownList1.DataSource = dr;
            //    DropDownList1.DataBind();
            //}



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // 1. Connection Object

            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QGTOJ74;Initial Catalog=JulyDotNet2020;Integrated Security=True");

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into  EmployeeTbl(empName, empSal) values('"
                + TxtEmpNane.Text+"'," + TxtSal.Text+")", conn);
            int x = cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
           
            
        }

        protected void txtUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("update EmployeeTbl set empName = @empName" +
                ", empSal = @empId where empId=@empId", conn);
            cmd.Parameters.Add("@empId", SqlDbType.Int).Value = Convert.ToInt32(TxtEmp.Text);
            cmd.Parameters.Add("@empName", SqlDbType.VarChar,20).Value = (TxtEmpNane.Text);
            cmd.Parameters.Add("@empSal", SqlDbType.Float).Value = Convert.ToSingle(TxtSal.Text);
           
         if(cmd.ExecuteNonQuery()>0)
            {
                Response.Write("alert(One row updated)");
            }
            conn.Close();
            ShowGrid();
        
        }

        protected void DelBtnWithSp_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_DeleteEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value =
                Convert.ToInt32(TxtEmp.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_searchEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empid", SqlDbType.Int).Value =
                Convert.ToInt32(TxtEmp.Text);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                TxtEmpNane.Text = dr[0].ToString();
                TxtSal.Text = dr[1].ToString();
            }
            else
            {
                TxtEmpNane.Text = "EmpId is not Found!!";
            }
            dr.Close();
            conn.Close();
            
        }

        protected void TxtSal_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnPara_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into EmployeeTbl(empName, empSal) values(@empName, @empSal)"
                , conn);
           // cmd.Parameters.Add("@empId", SqlDbType.Int).Value = Convert.ToInt32(TxtEmp.Text);
            cmd.Parameters.Add("@empName", SqlDbType.VarChar, 20).Value = (TxtEmpNane.Text);
            cmd.Parameters.Add("@empSal", SqlDbType.Float).Value = Convert.ToSingle(TxtSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void BtnIsp_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insertSp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@empName", SqlDbType.VarChar, 20).Value = (TxtEmpNane.Text);
            cmd.Parameters.Add("@empSal", SqlDbType.Float).Value = Convert.ToSingle(TxtSal.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }
    }
}