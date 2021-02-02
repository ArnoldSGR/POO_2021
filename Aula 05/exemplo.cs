using System;

class MinhaClass {

  public static void Main (string[] args){
    int i = 0;

    while(i <= 4){
      Console.WriteLine(i++ + ++i);
    }
  }
}