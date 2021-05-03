using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nationality_Recognition_Game
{
    public class operators
    {
        public Func<int, int, bool> _opEqualEqualTo = (a, b) => a == b;
        public Func<int, int, bool> _opNotEqualTo = (a, b) => a != b;
        public Func<int, int, bool> _opLessThan = (a, b) => a < b;
        public Func<int, int, bool> _opLessThanEqualTo = (a, b) => a <= b;
        public Func<int, int, bool> _opGreaterThan = (a, b) => a > b;
        public Func<int, int, bool> _opGreaterThanEqualTo = (a, b) => a >= b;
        public Func<int, int, int> opPlus = (a, b) => a + b;
        public Func<int, int, int> opMinus = (a, b) => a - b;
    }
}
