using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class id
    {
        private int idOb;
        public id() {
            idOb = 0;
        }
        public int IdOb { 
            get { return idOb; }
            set { idOb = value; }
        }
    }
}
