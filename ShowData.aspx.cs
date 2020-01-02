using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class ShowData : System.Web.UI.Page
{ public SqlConnection scn;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            String str1 =FileUpload1.FileName;
        }
        string str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        using (scn = new SqlConnection(str))
        {
            
            SqlCommand insertcommand = new SqlCommand("Sp_InsertData", scn);
            insertcommand.CommandType = CommandType.StoredProcedure;
            insertcommand.Parameters.AddWithValue("Name", TextBox2.Text);
            insertcommand.Parameters.AddWithValue("Contact", Convert.ToInt32( TextBox3.Text));
            insertcommand.Parameters.AddWithValue("Impath",FileUpload1.FileName);
            scn.Open();
            int n=            insertcommand.ExecuteNonQuery();
            if (n > 0)
            {
                Response.Write("Record Inseted successfully");
            }
            else
            {
                Response.Write("Record  not Inserted successfully");

            }



        }
    }

    protected void BindGrid()
           {


        SqlDataAdapter sdr = new SqlDataAdapter("select * from InsertData", scn);
        DataSet ds = new DataSet();
        sdr.Fill(ds);
        GridView1.DataSource =ds;
    GridView1.DataBind();

}
protected void GridView1_RowCancelingEdit(object sender)
{
    GridView1.EditIndex = -1;
    BindGrid();
}
protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
{
    Label lcid = (Label)GridView1.Rows[e.RowIndex].FindControl("Id");
    String sql = "delete from InsertData where Id="+lcid.Text;
    if (true)
    {
        Response.Redirect("<script>alert(' RECORD DELETED SUCCESSFULLY............');</script>");
        GridView1.EditIndex = -1;
        BindGrid();
    }
}
protected void GridView1_PageIndexChanging(Object sender, GridViewPageEventArgs e)
{
    GridView1.PageIndex = e.NewPageIndex;
    BindGrid();
}


protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
{
    TextBox uuname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("tuname");
    TextBox upassword = (TextBox)GridView1.Rows[e.RowIndex].FindControl("tpassword");
    TextBox urepassword = (TextBox)GridView1.Rows[e.RowIndex].FindControl("trepassword");
    TextBox ufname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("tfname");
    TextBox ulname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("tlname");
    TextBox ugender = (TextBox)GridView1.Rows[e.RowIndex].FindControl("tgender");
    TextBox umob = (TextBox)GridView1.Rows[e.RowIndex].FindControl("tmob");
    TextBox uemail = (TextBox)GridView1.Rows[e.RowIndex].FindControl("temail");

    string sql = "update newuser set uname='" + uuname.Text + "',password='" + upassword.Text + "',repassword='" + urepassword.Text + "',fname='" + ufname.Text + "',lname='" + ulname.Text + "',gender='" + ugender.Text + "',mob='" + umob.Text + "',email='" + uemail.Text + "' where  uname='" + uuname.Text + "'";
    if (true)
    {
        Response.Write("<script>alert('CURRENT RECORD UPDATED SUCCESSFULLY............');</script>");
        GridView1.EditIndex = -1;
        BindGrid();
    }


}
protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
{

    try
    {
        Label lbl = (Label)GridView1.Rows[e.RowIndex].FindControl("luname");
        string sql = "delete from newuser where uname='" + lbl.Text + "'";
        SqlCommand delete=new SqlCommand(sql,scn);
            int n=delete.ExecuteNonQuery();

            if (n > 0)
            {
                Response.Write("<sript>alert('CURRENT RECORD delted successfully...');</script>");
                GridView1.EditIndex = -1;
                BindGrid();
            }

    }
        catch { }



    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
{
    GridView1.EditIndex = e.NewEditIndex;
    BindGrid();

}
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
 
   
    String s = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        using (SqlConnection scn = new SqlConnection(s))
        {
            SqlDataAdapter sdr = new SqlDataAdapter("Select * from InsertData where id=1", scn);
            DataSet ds = new DataSet();
            sdr.Fill(ds, "Student");
            ds.Tables["Student"].PrimaryKey =
           new DataColumn[] { ds.Tables["Student"].Columns["ID"] };

           
            

        }

       
    }
}