using System.Collections.Generic;

namespace Pruefsumme.I99_Loesung
{
  public static class PruefsummeAlgorithmen
  {
    public static Pruefsumme FürNetzwerkAdressen()
    {
      return new Pruefsumme(Int64Extensions.DigitsFromRightToLeft,
        Gewichtungen(), 9);
    }

    public static Pruefsumme FürRechnungsnummern()
    {
      return new Pruefsumme(Int64Extensions.DigitsFromLeftToRight,
        Gewichtungen(), 7);
    }

    private static IEnumerable<int> Gewichtungen()
    {
      while (true)
      {
        yield return 5;
        yield return 1;
      }
    }
  }
}