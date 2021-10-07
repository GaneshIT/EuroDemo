using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderManagementApp
{
    public partial class Salesman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConnection dbObj = new DbConnection();
            DataTable dtSalesmanResult = dbObj.GetSalesmans();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string salesmanname = "";
            string salesmancity = "";
            string commission = "";
            salesmanname = txtSalesmanname.Text;
            salesmancity = txtSalesmancity.Text;
            commission = txtSalesmancommision.Text;
            DbConnection dbObj = new DbConnection();
            dbObj.InsertSalesman(salesmanname, salesmancity, commission);
            lblResult.Text = "Salesman data inserted successfully";
            DataTable dtSalesmanResult = dbObj.GetSalesmans();

            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        protected void gvSalesmanDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int salesmanid =Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetSalesmanById(salesmanid);
                txtSalesmanname.Text = dt.Rows[0][1].ToString();
                txtSalesmancity.Text = dt.Rows[0][2].ToString();
                txtSalesmancommision.Text = dt.Rows[0][3].ToString();
                lblSalesmanid.Text= dt.Rows[0][0].ToString();
            }
            else
            {
                
            }
        }

        protected void gvSalesmanDetails_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void gvSalesmanDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            dbConnection.UpdateSalesman(Convert.ToInt32(lblSalesmanid.Text), txtSalesmanname.Text, txtSalesmancity.Text, txtSalesmancommision.Text);
           
            DataTable dtSalesmanResult = dbConnection.GetSalesmans();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
        }
    }  
}