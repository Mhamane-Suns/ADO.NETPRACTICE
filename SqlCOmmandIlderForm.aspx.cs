using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

  

public partial class SqlCOmmandIlderForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void BUpdate_Click(object sender, EventArgs e)
    {
        String cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection sc = new SqlConnection(cs);
        SqlDataAdapter sd = new SqlDataAdapter((String)ViewState["SQL_QUERY"],sc);
        SqlCommandBuilder sb = new SqlCommandBuilder(sd);
        DataSet ds= (DataSet)ViewState["DATASET"];
        if (ds.Tables["Student"].Rows.Count > 0)
        {
         DataRow dr=ds.Tables["Student"].Rows[0];
            dr["Name"] = TextName.Text;
            dr["Gender"] = ddlGender.SelectedValue;
            dr["Marks"] = TextMarks.Text; 
        }
           int RowUpdated=sd.Update(ds, "Student");
        if (RowUpdated > 0)
        {
            LMessage.Text = RowUpdated.ToString() + "row updated";

        }
        else
        {
            if (RowUpdated > 0)
            {
                LMessage.Text = "NO row updated";

            }
        }

        LblInsert.Text =sb.GetInsertCommand().CommandText;
        LblUpdate.Text = sb.GetUpdateCommand().CommandText;
        LblDelete.Text = sb.GetDeleteCommand().CommandText;

    }

    protected void TextId_TextChanged(object sender, EventArgs e)
    {

        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        String SqlQuery = "select * from Student where id=" + TextId.Text;
        SqlConnection scn = new SqlConnection(cs);
        SqlDataAdapter da = new SqlDataAdapter(SqlQuery, scn);
        DataSet ds = new DataSet();
        da.Fill(ds, "Student");
        ViewState["SQL_QUERY"] = SqlQuery;
        ViewState["DATASET"] = ds;
        if (ds.Tables["Student"].Rows.Count > 0)
        {
            DataRow dr = ds.Tables["Student"].Rows[0];
            TextName.Text = dr["Name"].ToString();
            ddlGender.SelectedValue = dr["Gender"].ToString();
            TextMarks.Text = dr["Marks"].ToString();
        }
        else
        {
            LMessage.ForeColor = System.Drawing.Color.Red;
            LMessage.Text = "NO Record Found";
        }

    }
}