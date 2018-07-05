using System;

namespace Pruefsumme.I00_Problemstellung
{
  public static class Pruefsumme
  {
    //https://de.wikipedia.org/wiki/IP-Paket#Header_Checksum
    //https://de.wikipedia.org/wiki/Pr%C3%BCfsumme
    //https://de.wikipedia.org/wiki/Zyklische_Redundanzpr%C3%BCfung aka CRC
    public static int Erzeuge(string ip)
    {
      if (!long.TryParse(ip.Replace(".", string.Empty), out var zahl))
      {
        throw new ArgumentOutOfRangeException(nameof(ip));
      }

      var summe = 0;
      var istUngeradePosition = true;

      while (zahl > 0)
      {
        var ziffer = (int)(zahl % 10);
        if (istUngeradePosition)
          summe += 5 * ziffer;
        else
          summe += ziffer;

        zahl /= 10;
        istUngeradePosition = !istUngeradePosition;
      }

      var modulo = summe % 9;
      return modulo;
    }

  }
}