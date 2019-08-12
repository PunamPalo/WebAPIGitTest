using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SamlePPMVC.Models
{
    public class ProductModel
    {
        private List<Product> products;
        public ProductModel()
        {
            this.products = new List<Product>() {
                new Product {
                    Id = "p01",
                    Name = "A",
                    Price = 1.25,
                    Quantity = 1
                }, 
                new Product {
                    Id = "p01",
                    Name = "A",
                    Price = 3,
                    Quantity = 3
                },
                new Product {
                    Id = "p02",
                    Name = "B",
                    Price = 4.25,
                    Quantity = 1
                },
                new Product {
                    Id = "p03",
                    Name = "C",
                    Price = 1,
                    Quantity = 1
                },
                new Product {
                    Id = "p03",
                    Name = "C",
                    Price = 5,
                    Quantity = 6
                },
                new Product {
                    Id = "p04",
                    Name = "D",
                    Price = 0.75,
                    Quantity = 1
                },
                new Product {
                    Id = "p06",
                    Name = "No Product",
                    Price = 0,
                    Quantity = 0
                }
            };
        }
        public Product find(string name, int Qty)
        {
            return this.products.Single(p => p.Name == name.ToUpper() && p.Quantity == Qty);
        }

    }
}