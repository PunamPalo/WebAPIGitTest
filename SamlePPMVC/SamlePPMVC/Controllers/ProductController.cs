using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SamlePPMVC.Models;

namespace SamlePPMVC.Controllers
{
    public class ProductController : Controller
    {
        ProductModel productModel = new ProductModel();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CalculateBill(string items)
        {

            double price = 0;
            double amount = 0;


            
            int n = items.Length;
            string disItems = new String(items.Distinct().ToArray());
            int m = disItems.Length;

            string product = "";

            for (int i = 0; i < m; i++)
            {
                int Count = 0;
                foreach (char c in items)
                {
                    product = disItems[i].ToString();
                    if (product == c.ToString())
                    {
                        Count++;
                    }
                }

                if (product.ToUpper() == "A")
                {
                    if (Count == 3)
                    {
                        price = productModel.find(product, Count).Price;
                    }
                    else
                    {
                        price = Count * productModel.find(product, 1).Price;
                    }
                }
                else if (product.ToUpper() == "C")
                {
                    if (Count == 6)
                    {
                        price = productModel.find(product, Count).Price;
                    }
                    else
                    {
                        price = Count * productModel.find(product, 1).Price;
                    }
                }
                else if (product.ToUpper() == "B" || product.ToUpper() == "D")
                {
                    price = Count * productModel.find(product, 1).Price;
                }    

                else
                {
                    price = 0;
                }


                amount = amount + price;
            }

          
            return Json(amount, JsonRequestBehavior.AllowGet);
            // return View("Index");
        }

      
    }


}