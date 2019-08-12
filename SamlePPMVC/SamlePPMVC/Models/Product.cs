﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SamlePPMVC.Models
{
    public class Product
    {
        public string Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public double Price
        {
            get; set;
        }

        public int Quantity
        {
            get; set;
        }

    }
}