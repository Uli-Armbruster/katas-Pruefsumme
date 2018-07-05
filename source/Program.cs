using System;

namespace Pruefsumme
{
  internal static class Program
  {
    private static void Main()
    {
      Func<string, int> prüfzifferBerechnung = I00_Problemstellung.Pruefsumme.Erzeuge;

      var ip = "192.168.115.1";
      Console.WriteLine($"Prüfziffer zur IP {ip} lautet: {prüfzifferBerechnung(ip)}");

      ip = "10.10.148.1";
      Console.WriteLine($"Prüfziffer zur IP {ip} lautet: {prüfzifferBerechnung(ip)}");

      Console.ReadKey();
    }
  }
}