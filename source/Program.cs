using System;
using Pruefsumme.I99_Loesung;

namespace Pruefsumme
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      //Einfachere Verwendung
      //Bessere Verständlichkeit
      var localhost = IPv4Address.Localhost();
      localhost = new Localhost(); //alternativ

      Console.WriteLine("Prüfziffer zu Localhost lautet: " +
                        PruefsummeAlgorithmen
                          .FürNetzwerkAdressen()
                          .ErzeugeFürGanzzahl(localhost)
      );


      //Erweiterbarkeit
      //Wiederverwendbarkeit
      var rechnungsnr = 20180619001;
      Console.WriteLine("Prüfziffer zu Rechnungsnr lautet: " +
                        PruefsummeAlgorithmen
                          .FürRechnungsnummern()
                          .ErzeugeFürGanzzahl(rechnungsnr)
      );

      Console.ReadKey();
    }
  }
}