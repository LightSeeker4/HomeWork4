using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
        public abstract class View
        {
            public abstract void WriteLine(string s);
            public abstract string ReadLine();
        }
        public class ConsoleView : View
        {
            public override void WriteLine(string s)
            {
                System.Console.WriteLine(s);
            }
            public override string ReadLine()
            {
                return System.Console.ReadLine();
            }
        }
}