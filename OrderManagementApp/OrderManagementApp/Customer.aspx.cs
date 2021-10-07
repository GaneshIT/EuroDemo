using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderManagementApp
{
    public partial class Customer : System.Web.UI.Page
    {
        // ************Asp.net life cycle************
        //post back  - done
        // Page_PreInit()
        // Page_Init()
        // Page_Load()
        // Page_PreRender()   click
        // Page_Render()
        // Page_Unload()
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DbConnection dbConnection = new DbConnection();
                DataTable dt = dbConnection.GetSalesmanIds();
                ddlSalesmanid.Items.Add("--Select--");
                //ddlSalesmanid.DataSource = dt;
                //ddlSalesmanid.DataTextField = "name";
                //ddlSalesmanid.DataValueField = "salesman_id";
                //ddlSalesmanid.DataBind();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //ddlSalesmanid.Items.Add(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString());
                    ddlSalesmanid.Items.Add(new ListItem(dt.Rows[i][0].ToString() + " - " + dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
                }

            }
        }
        //5001 - Ganesh
        //5002 - Peru
        protected void btnSave_Click(object sender, EventArgs e)
        {
            int salesmaneid =Convert.ToInt32(ddlSalesmanid.SelectedValue.ToString());
            var salesmanname = ddlSalesmanid.SelectedItem.Text;
            DbConnection dbConnection = new DbConnection();
            dbConnection.InsertCustomer(3015,txtCustomername.Text, txtCustomercity.Text, txtGrade.Text, salesmaneid);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomername.Text = string.Empty;
            txtGrade.Text = string.Empty;
            txtCustomercity.Text = string.Empty;
        }
    }
}