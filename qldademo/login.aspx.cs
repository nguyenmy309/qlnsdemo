using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Configuration;

using System.Collections;


namespace qldademo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }

        }
        protected void login_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            con.Open();
            String query = " select * from NGUOIDUNG where TENDN = '" + inputEmail.Value + "'and MATKHAU = '" + inputPassword.Value + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            string output = cmd.ExecuteScalar().ToString();

            if (output == "ID1")
            {
                Session[""] = inputEmail.Value;
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Response.Write("");
            }
        }
    }
}