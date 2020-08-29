using System;

namespace Essential01
{
    public class Student : Base
    {
        public enum GradeLevels { One, Two, Three }
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGrade()
        {
            return 4.0f;
        }
    }
}