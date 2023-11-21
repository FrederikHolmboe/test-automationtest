using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_automationtest.Functions
{
    public class Functions
    {
        public int test1(int test1, bool multiply)
        {
            if (multiply)
                return test1 * test1;
            else
                return test1;
        }
    }
}
