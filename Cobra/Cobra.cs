﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra
{
    class Cobra
    {
        // properties
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static string currentDirection;

        // constructor
        public Cobra()
        {
            Width = 16;
            Height = 16;
            currentDirection = "left";
        }
    }
}
