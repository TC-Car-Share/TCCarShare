﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCCarShare.Models
{
    public class Car
    {
        public int id { get; set; }
        public string carNo { get; set; }
        public string carColor { get; set; }
        public int carType { get; set; }
        public string carBrand { get; set; }
        public int carSeatNum { get; set; }
        public string carLicenseImg { get; set; }
        public int carMasterId { get; set; }
    }
}
