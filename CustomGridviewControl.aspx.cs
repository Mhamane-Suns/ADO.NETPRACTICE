using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class CustomGridviewControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void GetData()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        string selectQuery = "Select * from Student1";
        SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);

        DataSet dataSet = new DataSet();
        dataAdapter.Fill(dataSet, "Students");
        // Set ID column as the primary key
        dataSet.Tables["Students"].PrimaryKey =
            new DataColumn[] { dataSet.Tables["Students"].Columns["ID"] };
        // Store the dataset in Cache
        Cache.Insert("DATASET", dataSet, null, DateTime.Now.AddHours(24),
            System.Web.Caching.Cache.NoSlidingExpiration);

        GridView1.DataSource = dataSet;
        GridView1.DataBind();

        LMessage.Text = "Data loded from Database";

    }
    private void GetDataFromCache()
    {
        if (Cache["DATASET"] != null)
        {
            GridView1.DataSource = (DataSet)Cache["DATASET"];
            GridView1.DataBind();
        }
        LMessage.Text = "Data is loaded from cache databse";
        }

    
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        GetDataFromCache();

    }


    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GetDataFromCache();

    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        // Retrieve dataset from cache
        DataSet dataSet = (DataSet)Cache["DATASET"];
        // Find datarow to edit using primay key
        DataRow dataRow = dataSet.Tables["Students"].Rows.Find(e.Keys["ID"]);
        // Update datarow values
        dataRow["Name"] = e.NewValues["Name"];
        dataRow["Gender"] = e.NewValues["Gender"];
        dataRow["Marks"] = e.NewValues["Marks"];
        // Overwrite the dataset in cache
        Cache.Insert("DATASET", dataSet, null, DateTime.Now.AddHours(24),
            System.Web.Caching.Cache.NoSlidingExpiration);
        // Remove the row from edit mode
        GridView1.EditIndex = -1;
        // Reload data to gridview from cache
        GetDataFromCache();

    
}

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (Cache["DATASET"] != null)
        {
            DataSet dataSet = (DataSet)Cache["DATASET"];
            dataSet.Tables["Students"].Rows.Find(e.Keys["ID"]).Delete();
            Cache.Insert("DATASET", dataSet, null, DateTime.Now.AddHours(24),
                System.Web.Caching.Cache.NoSlidingExpiration);
            GetDataFromCache();
        }

    }

    protected void BGetData_Click(object sender, EventArgs e)
    {
        GetData();
    }

    protected void BUpdateDatabase_Click(object sender, EventArgs e)
    {
        String cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection scn = new SqlConnection(cs);
        String SqlQuery = "select * from Student1";
        SqlDataAdapter sda = new SqlDataAdapter(SqlQuery, scn);
        DataSet ds = (DataSet) Cache["DATASET"];
        string sqlUpdateQuery = "update Student1 set Name=@Name,Marks=@Marks,Gender=@Gender where id=@ID";
        SqlCommand updatecommand = new SqlCommand(sqlUpdateQuery, scn);
        updatecommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50,"Name");
        updatecommand.Parameters.Add("@Gender", SqlDbType.NVarChar, 50, "Gender");
        updatecommand.Parameters.Add("@Marks", SqlDbType.BigInt, 0, "Marks");
        updatecommand.Parameters.Add("@Id", SqlDbType.Int, 0, "id");
        sda.UpdateCommand = updatecommand;

        string strDeleteCommand = "Delete from Student1 where id=@ID";
        SqlCommand deletecommand = new SqlCommand(strDeleteCommand, scn);
        deletecommand.Parameters.Add("@Id",SqlDbType.Int, 0, "id");
        sda.DeleteCommand = deletecommand;

        LMessage.Text = "Data is update in database";

    }





    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}