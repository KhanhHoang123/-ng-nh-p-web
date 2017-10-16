using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    
    protected void btDangnhap_Click(object sender, EventArgs e)
    {
        //string cnstr = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        //SqlConnection con = new SqlConnection(cnstr);
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
        con.Open();
        string query = "SELECT COUNT(*) FROM [login_page].[dbo].[User] where user_name='" + txtUser.Text+"' and pass ='"+txtPass.Text+"'";
        SqlCommand cmd = new SqlCommand(query, con);
        string output = cmd.ExecuteScalar().ToString();
        if (output == "1")
        {
            Session["user"] = txtUser.Text;
            Response.Redirect("~/welcome.aspx");
        }
        else
        {
            Response.Write("Đăng nhập thất bại");
        }
    }
}