using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra
{
    class Cobra
    {
        // properties
        public int Width { get; set; }
        public int Height { get; set; }
        public string currentDirection;

        // constructor
        public Cobra()
        {
            Width = 32;
            Height = 32;
            currentDirection = "left";
        }
    }
}
