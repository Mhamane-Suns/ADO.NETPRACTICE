using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

public partial class Insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    { String sqlconnection = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        using (SqlConnection scn = new SqlConnection(sqlconnection))
        {
            SqlCommand insert=new SqlCommand("insert into Student1 values('"+TextBox2.Text+"','"+TextBox3.Text+"',"+TextBox4.Text+")",scn);
            scn.Open();
            int n=insert.ExecuteNonQuery();
            if (n > 0)
            {
                Response.Write("Record Updated");
            }
            scn.Close();
            SqlDataAdapter sda = new SqlDataAdapter("Select* from Student1", scn);
            DataSet ds = new DataSet();
            sda.Fill(ds,"Student");
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }
        
    }
}