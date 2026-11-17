using System;
using System.Collections.Generic;
using System.Text;

namespace myzoo
{
    public class Animel
    {
        public string Name { get; set; }
        public double Weight { get; set; }
    public virtual string SayHello()
        {
            return "Hello" + Name;

        }
    }
}
