﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEHerancaJunto.Model.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return "Circle Color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}