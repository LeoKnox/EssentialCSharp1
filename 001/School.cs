using System;

namespace Essential01
{
    class School
    {
        //string SchoolName;
        string Name { get; set; } // pretty much same as previous line
        string City { get; set; }
        string Mascot { get; set; }
        string Color { get; set; }
        string _sm;
        string Socialmedia
        {
            // make sure address starts with @
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
    }
}