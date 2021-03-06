using System;
using System.Text;

namespace Essential01
{
    public class School
    {
        //string SchoolName;
        public string Name { get; set; } // pretty much same as previous line
        public string City { get; set; }
        public string Mascot { get; set; }
        public string Color { get; set; }
        private string _sm;
        public string Socialmedia
        {
            // make sure address starts with @
            // encapsulation logic
            get { return _sm; }
            set
            {
                if(value.StartsWith("@"))
                {
                    _sm = value;
                } else
                {
                    throw new Exception("Must start with @");
                }
            }
        }
        public School()
        {
            Name = "Untitled School";
            Color = "Gray";
        }
        public School(string SchoolName, string SchoolColor)
        {
            Name = SchoolName;
            Color = SchoolColor;
        }
        /*
        public float AvgThree(float a, float b, float c)
        {
            float result = (a + b + c)/3;
            return result;
        }
        */
        // function bodied version
        public static float AvgThree(float a, float b, float c) => (a + b + c)/3;
        public static int AvgThree(int a, int b, int c)
        {
            int result = (a + b + c)/3;
            return result;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Color);
            sb.AppendLine(Mascot);
            return sb.ToString();
        }
    }
}