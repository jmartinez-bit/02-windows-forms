﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_01
{
    public class Usuario
    {
        public string username { get; set; }
        public string password { get; set; }

        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
