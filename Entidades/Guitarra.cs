﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guitarra:InstrumentoMusical
    {
        public override string Afinar()
        {
            return base.Afinar() + "Guitarra...";
        }
    }
}
