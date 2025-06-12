using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MyClass
    {
        public MyClass(int i) { this.i = i; }
        public MyClass(string s) 
        {
            try
            {
                i = Convert.ToInt32(s);
            }
            catch (FormatException)
            {
                try
                {
                    b = Convert.ToBoolean(s);
                }
                catch(FormatException)
                {
                    this.s = s;
                }
            }
        }

        public int i;
        public string s;
        public bool b;
    }
}
