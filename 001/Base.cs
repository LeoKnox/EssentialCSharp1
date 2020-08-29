using System;

namespace Essential01
{
    public abstract class Base
    {
        public string Name { get; set; }
        public string Hobby { get; set; }

        public abstract float ComputeGrade();
    }
}