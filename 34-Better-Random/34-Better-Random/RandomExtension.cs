using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Better_Random {
    public static class RandomExtension {

        public static double NextDouble(this Random random, double max) => random.NextDouble() * max;

        public static string NextString(this Random random, params string[] options) => options[random.Next(options.Length)];

        public static bool CoinFlip(this Random random, double probability = 0.5) => random.NextDouble() < probability;
    }
}
