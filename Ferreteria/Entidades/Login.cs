﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Entidades
{
    [Table("login")]
    public class Login
    {
        [Key]
        public int id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
    }
}
