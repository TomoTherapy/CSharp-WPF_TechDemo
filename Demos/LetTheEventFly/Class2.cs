using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LetTheEventFly
{
    internal class Class2
    {
        public delegate void Something(int a, int b, int c, string d);
        public event Something SomeEvent;
        private int a = 2;
        private int b = 1;
        private int c = 0;

        public Class2()
        {
            int cnt = 0;
            Thread t = new Thread(new ThreadStart(delegate 
            {
                while (cnt < 20)
                {
                    SomeEvent(a, b, c, "Mein Führer!");
                    a++;
                    b++;
                    c++;
                    cnt++;
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
        }
    }
}
