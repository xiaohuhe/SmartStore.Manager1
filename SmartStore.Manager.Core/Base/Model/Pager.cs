﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStore.Manager.Core.Base.Model
{
   public class Pager<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public List<T> Data { get; set; }
    }
}
