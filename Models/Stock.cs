﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityDataBaseFirst.Models
{
    public partial class Stock
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public string Symbol { get; set; }

        public string Sector { get; set; }
        public string Industry { get; set; }


        public string Balance { get; set; }
    }
}
