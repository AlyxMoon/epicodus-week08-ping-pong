using System;
class PingPong
{
  static void Main()
  {
    int range = int.Parse(Console.ReadLine());

    for (int i = 1; i <= range; i++) {
      string result = doPingPong(i);
      Console.WriteLine(result);
    }
  }

  static string doPingPong (int num)
  {
    if (num % 15 == 0) {
      return "ping-pong";
    } else if (num % 3 == 0) {
      return "ping";
    } else if (num % 5 == 0) {
      return "pong";
    }

    return num.ToString();
  }
}