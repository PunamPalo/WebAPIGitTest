using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_MVC.Controllers
{
    public class CalculatePriceController : ApiController
    {

        
        [HttpGet]
        public float GetDetails(string product, int qty, float price)
        { 
            // i did this in static way just because we have to set all those price and offfers in master tables //
            float finalprice;
            if (product == "A" && qty == 3)
            {
                finalprice = 3;
            }
            else
            {
                finalprice = price;
            }
            float result = qty * finalprice;
            float ttlresult = 0;
            ttlresult = result + ttlresult;
            return ttlresult;
        }

     
        }
}
