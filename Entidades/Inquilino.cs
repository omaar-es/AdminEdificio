﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inquilino:Persona
    {
        public Inquilino(string n, string a1, string a2, string rFC) : base(n, a1, a2, rFC) { 

        }
        public Inquilino() : base()
        {
            IdOb = -1;
        }
        
    }
}
