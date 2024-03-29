﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCCarShare.Models;

namespace TCCarShare.Entity.Response
{
    public class GetLineListByEmpIdResponse : CommonBaseInfo
    {
        public string origin { get; set; }

        public string destination { get; set; }

        public string startPoint { get; set; }

        public string endPoint { get; set; }

        public string workTime { get; set; }

        public string overTime { get; set; }

        public int empId { get; set; }

        public List<Line> LineList { get; set; }
    }
}
