using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class UpdateGridView : System.Web.UI.Page
{
    int empno = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            //empno = Convert.ToInt32(Request.QueryString["EmpNo"].ToString());
           //B btnSave.Visible = false;
            //BindTextBoxvalues();
        }
    }

    private void BindTextBoxvalues()
    {
        string constr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand("select * from Emp where EmpNo=" + empno, con);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        txtEmpId.Text = dt.Rows[0][0].ToString();
        txtEmpName.Text = dt.Rows[0][1].ToString();
        txtJob.Text = dt.Rows[0][2].ToString();
        txtEmpSalary.Text = dt.Rows[0][3].ToString();
        txtDept.Text = dt.Rows[0][4].ToString();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string constr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand("update Emp set EmpName='" + txtEmpName.Text + "',Job='" + txtJob.Text + "',Sal=" + txtEmpSalary.Text + ",Dept='" + txtDept.Text + "' where EmpNo=" + empno, con);
        con.Open();
        int result = cmd.ExecuteNonQuery();
        con.Close();
        if (result == 1)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowSuccess", "javascript:alert('Record Updated Successfully');", true);
        }
        Response.Redirect("~/WebForm1.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/WebForm1.aspx");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        txtEmpId.Text =( empno + 1).ToString();
        string constr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand("insert into  Emp values ('"+txtEmpName.Text + "','" + txtJob.Text + "'," + txtEmpSalary.Text + ",'" + txtDept.Text+"'", con);
        con.Open();
        int result = cmd.ExecuteNonQuery();
        con.Close();
        if (result == 1)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowSuccess", "javascript:alert('Record Updated Successfully');", true);
        }
        Response.Redirect("~/WebForm1.aspx");


    }
}