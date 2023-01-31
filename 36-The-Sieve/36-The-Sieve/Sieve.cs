using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_The_Sieve {
    public class Sieve {
        private Func<int, bool> decisionFunc;

        public Sieve(Func<int, bool> decisionFunc) {
            this.decisionFunc = decisionFunc;
        }

        public bool IsGood(int number) => this.decisionFunc(number);
    }
}
