using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum IdolAttribute {
  Cute,
  Cool,
  Passion
}

class Program {
  static void Main(string[] args) {
    var names = Enum.GetNames(typeof(IdolAttribute));
    foreach (var name in names) {
      var e = (IdolAttribute)Enum.Parse(typeof(IdolAttribute), name);
      Console.WriteLine("{0}={1}", name, (int)e);
    }
  }
}

// _5_21
/* 
 // クラスは型なので、クラス型の変数を作れる。
      Hoge obj; // ただしこの時点で変数は無効(null)な状態。

      // クラスを利用するにはインスタンス(実態)が必要。
      // インスタンスを作るにはnew演算子を使う。
      obj = new Hoge();

      // オブジェクトのメンバにアクセスするには
      // メンバアクセス演算子.を使う。
      // 使い方:オブジェクト.メンバ
      //obj.value = 100;
      //Console.WriteLine("value = " + obj.value);
      // Console.WriteLine("value = " + ((new Hoge()).value = 100));
      obj.show();

      Point pt = new Point { x = 10, y = 10 };
      var text = string.Format("x = {0}, y = {1}", pt.x, pt.y);
      Console.WriteLine(text);

      Console.WriteLine("x = " + pt.x + "y = " + pt.y);
*/

// _5_28
/*
class Sample {
  public int add(int a , int b) {
    return a + b;
  }
}

class Program {
  static void Main(string[] args) {
    var obj = new Sample();
    var r1 = obj.add(1,2);
    var r2 = obj.add(21, 18);

    Console.WriteLine("r1 = " + r1);
    Console.WriteLine("r2 = " + r2);
  }
}
*/

// _5_28
/*
  class FibonacciSequencer {
  private int call_count;
  private int f0 = 0;
  private int f1 = 1;

  public int Next() {
    call_count++;
    if (call_count == 1) {
      return f0;
    }
    else if (call_count == 2) {
      return f1;
    }

    int next = f0 + f1;
    f0 = f1;
    f1 = next;

    return next;
  }
}

class Test {
  private int _count = 0;
  private const double Phi = 1.618033988749895;
  private const double Sqrt5 = 2.2360679775;

  public int Next(int num) {
    return 
      (int)Math.Floor(
        Math.Pow(Phi, _count++) / Sqrt5 + 0.5
      );
  }
}

class Program {
  static void Main(string[] args) {
    var f = new Test();
    Console.WriteLine(f.Next(0)); // 0
    Console.WriteLine(f.Next(1)); // 1
    Console.WriteLine(f.Next(2)); // 1
    Console.WriteLine(f.Next(3)); // 2
    Console.WriteLine(f.Next(4)); // 3
    Console.WriteLine(f.Next(5)); // 5
    Console.WriteLine(f.Next(6)); // 8
    Console.WriteLine(f.Next(7)); // 13
    Console.WriteLine(f.Next(8)); // 21
  }
} 
*/
#region rori
#endregion

// _6_04
/*
class Point {
  public int X ,Y;
  public Point(int x, int y) {
    this.X = x; // パラメータを初期化
    this.Y = y;
    Console.WriteLine("Point ctor X={0}, Y={1}", x, y);
  }
}

class Program {
  static void Main(string[] args) {
    var pt = new Point(1, 2);
    Console.WriteLine("Point ctor X={0}, Y={1}", pt.X, pt.Y);
  }
}
*/
#region getter&setter

#endregion

#region _6_11
/*
 * class Point {
  // フィールドは通常publicにしない
  private int _x, _y; // バッキングフィールド

  public Point(int x, int y) { _x = x; _y = y; }

  // _xに対するアクセサー
  public int GetX() { return _x; }     // getter
  //public void SetX(int x) { _x = x; }  // setter

  // _yに対するアクセサー
  public int GetY() { return _y; }
  //public void SetY(int y) { _y = y; }
}

class Program {
  static void Main(string[] args) {
    var pt = new Point(1, 2);
    //pt.SetX(1); pt.SetY(2);
    Console.WriteLine("pt X={0}, Y={1}", pt.GetX(), pt.GetY());
  }
}
*/
#endregion
#region _6_11
/*
   public Point(int x, int y) { this.X = x; this.Y = y; }

  // フィールドは通常publicにしない
  //private int _x;
  //public int GetX() { return _x; }     // getter
  //public void SetX(int x) { _x = x; }  // setter

  //// プロパティー
  //public int X {
  //  get { return _x; }
  //  private set { _x = value; }
  //}

  //private int _y;
  //public int GetY() { return _y; }
  //public void SetY(int y) { _y = y; }

  //public int Y {
  //  get { return _y; }
  //  set { _y = value; }
  //}

  //private int _z;

  //public int Z {
  //  get { return _z; }
  //  set { _z = value; }
  //}

  public int X { get; private set; }
  public int Y { get; private set; }
  public int Z { get; private set; }
*/
#endregion
