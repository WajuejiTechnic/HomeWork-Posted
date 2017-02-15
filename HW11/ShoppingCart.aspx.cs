using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text);

        String connectionString = @"Data Source=DESKTOP-QC3DJGB\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        sqlConnection.Open();
        var sqlDataAdapter = new SqlDataAdapter("usp_Customer_Select1", connectionString);
        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("Id", id);

        DataSet dataSet = new DataSet();
        sqlDataAdapter.Fill(dataSet);
        DataTable dataTable = dataSet.Tables[0];

        if (dataTable.Rows.Count == 0)
        {
            lbInfo.Text = "Cannot find this user profile";
        }
        else
        {
            lbInfo.Text = String.Empty;//""

            //txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
            DataRow firstDr = dataTable.Rows[0];
            //firstDr["FirstName"]
            var dc = firstDr[1];
            txtFirstName.Text = dc.ToString();

            txtLastName.Text = firstDr["LastName"].ToString();
            txtEmail.Text = firstDr["Email"].ToString();
            txtUserName.Text = firstDr["UserName"].ToString();
            txtPassword.Text = firstDr["Password"].ToString();
            txtPhone.Text = firstDr["Phone"].ToString();
            txtCreatedDate.Text = firstDr["CreatedDate"].ToString();
        }
    }

    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        String connectionString = @"Data Source=DESKTOP-QC3DJGB\SQLEXPRESS; Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand("usp_Customer_Insert", sqlConnection);
        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("FirstName", txtFirstName.Text);
        sqlCommand.Parameters.AddWithValue("LastName", txtLastName.Text);
        sqlCommand.Parameters.AddWithValue("Email", txtEmail.Text);
        sqlCommand.Parameters.AddWithValue("Phone", txtPhone.Text);
        sqlCommand.Parameters.AddWithValue("UserName", txtUserName.Text);
        sqlCommand.Parameters.AddWithValue("PassWord", txtPassword.Text);
        sqlCommand.Parameters.AddWithValue("CreatedDate", txtCreatedDate.Text);
        int rows = sqlCommand.ExecuteNonQuery();



        lbInfo.Text = "User Profiler registered...";

        sqlConnection.Close();
    }

}