using System;
using System.Text;

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
        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is for student");
            return sb.ToString();
        }
    }
}