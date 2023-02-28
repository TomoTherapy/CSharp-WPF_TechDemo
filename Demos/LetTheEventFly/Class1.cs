using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetTheEventFly
{
    internal class Class1
    {
        public delegate void Something(int a, int b, int c, string d);
        public event Something SomeEvent;
        private int a;
        private int b;
        private int c;

        public Class1()
        {
            a = 1;
            b = 2;
            c = 3;
        }

        public void RaiseSomeEvent()
        {
            SomeEvent(a++, b++, c++, "Fuck!");
        }
    }
}
