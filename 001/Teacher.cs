using System;

namespace Essential01
{
    public class Teacher : Base
    {
        public string Subject {get; set; }
        public override float ComputeGrade()
        {
            return 1.0f;
        }
    }
}