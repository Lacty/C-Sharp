using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum SceneType { 
  Title,
  GameMain,
  Result
}

class Program {
  static void Main(string[] args) {
    SceneType scene = SceneType.GameMain;

    switch (scene) { 
      case SceneType.Title:
        Console.WriteLine(scene);
        Console.WriteLine((int)scene);
      break;

      case SceneType.GameMain:
        Console.WriteLine(scene);
        Console.WriteLine((int)scene);
      break;

      case SceneType.Result:
        Console.WriteLine(scene);
        Console.WriteLine((int)scene);
      break;
    }
  }
}
