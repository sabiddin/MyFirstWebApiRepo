using MyFirstWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApi.Business
{
    public class ProductBusiness
    {
        //private List<Product> _Products = new List<Product>() {
        //    new Product {ProductId =1,ProductName ="Product 1", Price = 10.00 },
        //         new Product {ProductId =2,ProductName ="Product 2", Price = 10.00 } ,
        //              new Product {ProductId =3,ProductName ="Product 3", Price = 10.00 }         
        //};
        public List<Product> GetProducts() {
            using (ProductsDataContext db=new ProductsDataContext())
            {
                return db.Product.ToList();
            }
        }
        public Product GetProduct(int id) {

            using (ProductsDataContext db = new ProductsDataContext())
            {
                return db.Product.FirstOrDefault(p =>p.ProductId== id);
            }
        }
        public bool Create(Product product)
        {
            //int maxId = _Products.Max(p => p.ProductId);
            // product.ProductId = maxId++;
            bool success = false;
            try
            {
                using (ProductsDataContext db=new ProductsDataContext())
                {
                    db.Product.Add(product);
                    db.SaveChanges();
                    success = true;
                }
            }
            catch (Exception)
            {
               
                throw;
            }
            return success;          
        }

    }
}