using System;
using System.Collections.Generic;
using System.Text;

namespace myzoo
{
    public class dog : Animel
    {
        public override string SayHello()
        {
            return $"Dog {Name} says : Woof!";
        }
    }
}
