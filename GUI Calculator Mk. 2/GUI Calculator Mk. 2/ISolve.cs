using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Calculator_Mk._2
{
    interface ISolve
    {
        void Accumulate(string s);
        void Clear();
        double Solve(string s);
    }
}
