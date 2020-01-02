using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class SpGetData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String sc = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        using (SqlConnection scn = new SqlConnection(sc))
        {
            SqlDataAdapter sda = new SqlDataAdapter("SpGetData", scn);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            System.Data.DataSet ds = new System.Data.DataSet();
            sda.Fill(ds);
            GridView2.DataSource = (DataSet)Cache["data"];
            GridView2.DataBind();

        }

    }
}