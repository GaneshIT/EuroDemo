using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    //named parameters, optionals parameters
    #region class
    class Product
    {
        #region properties
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        #endregion

        #region Methods

        /// <summary>
        /// product constructor is going to save product data
        /// </summary>
        /// <param name="productid"></param>
        /// <param name="productname"></param>
        /// <param name="price"></param>
        public Product()
        {

        }

        public void InsertProduct()
        {

        }

        /// <summary>
        /// Get product by passing product id.
        /// </summary>
        /// <param name="productid"></param>
        public void GetProductByid(int productid)
        {

        }
        public void DeleteProductByid(int productid)
        {

        }
        public void GetProducts()
        {

        }
        #endregion
    }
    class Sales
    {
        public void GetSales()
        {
            Product product = new Product();
        }
    }

    #endregion

    #region product interface
    interface IProduct
    {

    }
    interface ISales
    {

    }
    #endregion
}
