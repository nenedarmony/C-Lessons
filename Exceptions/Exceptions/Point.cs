﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
       
        public void Invalid()
        {
            if (X>Y)
            {
                throw new PointException();
            }
        }
       
    }
}