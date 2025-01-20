using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo
{
    abstract internal class BaseForRevString
    {
        public virtual int VirMeth(int a, int b)
        {
            int res = a + b;
            return res;
        }
        public abstract int absmeth(int a, int b);
        public abstract int absmeth1(int a, int b);
        public int conmeth(int a, int b)
        {
            int res = a * b;
            return res;
        }
        
    }
}
