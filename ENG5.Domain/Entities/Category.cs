﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ENG5.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
