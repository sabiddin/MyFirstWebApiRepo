using MyFirstWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApi.Business
{
    public class ProductBusiness
    {
        private List<Product> _Products = new List<Product>() {
            new Product {ProductId =1,ProductName ="Product 1", Price = 10.00 },
                 new Product {ProductId =2,ProductName ="Product 2", Price = 10.00 } ,
                      new Product {ProductId =3,ProductName ="Product 3", Price = 10.00 }         
        };
        public List<Product> GetProducts() {
            return _Products;
        }
        public Product GetProduct(int id) {

            return _Products.FirstOrDefault(p => p.ProductId == id);

            //Product product = new Product();
            //foreach (var prod in _Products)
            //{
            //    if (prod.ProductId ==id)
            //    {
            //        product = prod;
            //    }
            //}
            //return product;
        }
        public bool Create(Product product)
        {
           int maxId = _Products.Max(p => p.ProductId);
            product.ProductId = maxId++;

            _Products.Add(product);
            return true;
        }

    }
}