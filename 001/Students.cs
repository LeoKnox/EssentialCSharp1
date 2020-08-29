using System;

namespace Essential01
{
    public class Sutdent : Base
    {
        public enum GradeLevels { One, Two, Three }
        public GradeLevels GradeLevel { get; set; }
    }
}