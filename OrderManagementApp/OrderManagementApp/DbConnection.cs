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
        public void GetSalesmanById(int salesmanId)
        {

        }

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
