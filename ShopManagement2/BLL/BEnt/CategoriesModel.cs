﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class CategoriesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public int ShopId { get; set; }
    }
}
