using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace OrderManagementApp
{
    public class DbConnection
    {
        #region salesman
        public void InsertSalesman(string salesmanName,string city,string commision)
        {        
            SqlConnection sqlConnection = new SqlConnection("Data Source = W10JQQGN13; Initial Catalog = ProductDb; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("insert into salesman values('"+salesmanName+"','"+city+"',"+commision+")", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateSalesman(int salesmanId,string salesmanName, string city, string commision)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = W10JQQGN13; Initial Catalog = ProductDb; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("update salesman set name='" + salesmanName + "' , city='" + city + "' , commission=" + commision + " where salesman_id="+salesmanId+"", sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeleteSalesmanById(int salesmanId)
        {

        }
        public DataTable GetSalesmans()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = W10JQQGN13; Initial Catalog = ProductDb; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from salesman", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetSalesmanById(int salesmanId)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = W10JQQGN13; Initial Catalog = ProductDb; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select * from salesman where salesman_id="+salesmanId+"", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        public DataTable GetSalesmanIds()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = W10JQQGN13; Initial Catalog = ProductDb; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand("select salesman_id,name from salesman", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            sqlConnection.Close();
            return dt;
        }
        #endregion salesman

        #region customer
        public string InsertCustomer(int customerid,string name, string city, string grade,int salesmanid)
        {
            string insertQuery = "insert into customer values(" + customerid + ",'" + name + "','" + city + "','" + grade + "'," + salesmanid + ")";
            ExecuteQry(insertQuery);
            return "Inserted";
        }
        public DataTable GetCustomers()
        {
            string selectcustomerQry = "select * from customer";
            DataTable dt = ExecuteQry(selectcustomerQry);
            return dt;
        }

        public DataTable ExecuteQry(string query)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source = W10JQQGN13; Initial Catalog = ProductDb; Integrated Security = True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        /*
         * create proc myproc
         * select * from customer
         * select * from salesman
         * select * from orders
         * 
         * exec myproc
         */
        //datatable and dataset
        //dataset contains tables
        //datatable contains rows&colmns
        //public DataTable ExecuteQry(string query)
        //{
        //    SqlConnection sqlConnection = new SqlConnection("Data Source = W10JQQGN13; Initial Catalog = ProductDb; Integrated Security = True");
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
        //    DataTable dt = new DataTable();
        //    sqlDataAdapter.Fill(dt);
        //    return dt;
        //}
        #endregion
    }

}
/*Classes
 *Sqlconnection - connection establishment between sql and .net
 *sqldatareader - read/retrieve data from sql resultset
 *sqlcommand - passing sql commands(insert,update,select,delete,etc)
 *
 *Methods
 *ExecuteNonQuery() - execute sql commands -insert,update,delete,
 *ExecutreReader() - execute select commands
 */



/*
 * Entity Framework
 * Open-source object-relational mapping (ORM) Framework for .NET applications
 * 
 * SQL Table: columns(SalesmanId,Name,City,Commission)
 * 
 * 
 * C#:Model-> class salesman{
 * int salesmaneid
 * string name
 * string city
 * double commission
 * }
 * 
 * 1.Database first approach
 * 2.code first approach
 */

