﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCCarShare.Models;

namespace TCCarShare.Entity.Response
{
    public class GetEmployeeByIdResponse : CommonBaseInfo
    {
        public Employee Employee { get; set; }
    }
}
