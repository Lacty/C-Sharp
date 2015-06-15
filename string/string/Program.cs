using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string {
  class Program {
    static void Main(string[] args) {
      //---------------------------------------------------
      // char
      char char_test = 'a';
      Console.WriteLine(char_test);
      char_test = 'b';
      Console.WriteLine(char_test);

      char[] n = {'a', 'b', 'c', 'd', 'e'};
      Console.WriteLine(n); // abcde
      n[4] = 'a';
      Console.WriteLine(n); // abcda
      // n[5] = 'a'; // err
      Console.WriteLine(n[1]); // b


      //---------------------------------------------------
      // string
      string name = "yanai";
      Console.WriteLine(name); // yanai
      Console.WriteLine(name[0]); // y
    }
  }
}
