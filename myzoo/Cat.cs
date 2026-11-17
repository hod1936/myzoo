using System;
using System.Collections.Generic;
using System.Text;

namespace myzoo
{
    public class Cat : Animel
    {
        public override string SayHello()
        {
           return $"cat {Name} says meow";
        }
    }
}
