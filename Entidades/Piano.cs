using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Piano:InstrumentoMusical
    {
        public override string Afinar()
        {
            return base.Afinar() +"Piano...";
        }
    }
}
