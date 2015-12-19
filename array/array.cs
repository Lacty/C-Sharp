
using System;

class ArrayTest {
  static void Main(string[] args) {
    int[] val = { 0, 1, 2 };
    for (int i = 0; i < 3; i++) {
      Console.WriteLine("val[{0}] = {1}", i, val[i]);
    }
  }
}
