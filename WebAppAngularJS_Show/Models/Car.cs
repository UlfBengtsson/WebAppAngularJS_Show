﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppAngularJS_Show.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(25)]
        public string Brand { get; set; }
    }
}