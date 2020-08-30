using System;
using System.Text;

namespace Essential01
{
    public abstract class Base
    {
        public string Name { get; set; }
        public string Hobby { get; set; }

        public abstract float ComputeGrade();
        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeSent = string.Format("Send on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeSent);
            sb.AppendLine("");
            sb.AppendLine("Dear " + Name + ",");
            sb.AppendLine(message);
            return sb.ToString();
        }
    }
}