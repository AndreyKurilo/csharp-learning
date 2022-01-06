using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRef
{
    class Test
    {
        int d, f;
        public Test(int i, int j) 
        { 
            i = i + j; 
            j += i;
            d = i;
            f = j;
        }
    }
}
