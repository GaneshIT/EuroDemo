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

            DataTable dtSalesmanResult = dbObj.GetSalesmans();
            gvSalesmanDetails.DataSource = dtSalesmanResult;
            gvSalesmanDetails.DataBind();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        
    }  
}