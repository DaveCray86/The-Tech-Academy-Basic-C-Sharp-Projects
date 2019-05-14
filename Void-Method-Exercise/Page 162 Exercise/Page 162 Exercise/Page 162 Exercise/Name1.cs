using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_162_Exercise
{
    class Name1
    {
        string _fname = "";
        string _id = "";

        public Name1(string name, string id)
        {
            _fname = name;
            _id = id;
            Console.WriteLine("Employee name and id is: {0}, {1}", name, id);
        }

        public Name1(string name) : this(name, "5236")
        {
        }
    }
}
