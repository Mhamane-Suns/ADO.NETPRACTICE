using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class ClearCacheForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Cache["data"] != null)
        {
            Cache.Remove("data");
            Label1.Text = "Data is cleared from cache";
        }
        else { Label1.Text = "Cache  is EMPTY"; }

    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        if (Cache["data"] == null)
        {

            String cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection scn = new SqlConnection(cs))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from TblProduct ", scn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                Cache["data"] = ds;
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Label1.Text = "Daata is Load from Database";
            }
        }
        else
        {
            GridView1.DataSource = (DataSet)Cache["data"];
            GridView1.DataBind();
            Label1.Text = "Data is Load from cache";



        }
}
}