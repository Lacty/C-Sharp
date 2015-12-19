using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array {
  class Program {
    static void Main(string[] args) {
      int[] val = { 0, 1, 2, 3, 4 };
      for (int i = 0; i < 5; ++i) {
        Console.WriteLine("val[{0}] = {1}", i, val[i]);
      }
    }
  }
}
