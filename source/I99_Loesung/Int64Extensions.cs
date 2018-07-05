using System.Collections.Generic;
using System.Linq;

namespace Pruefsumme.I99_Loesung
{
  public static class Int64Extensions
  {
    public static IEnumerable<int> DigitsFromRightToLeft(this long number)
    {
      do
      {
        yield return (int) (number % 10);
        number /= 10;
      } while (number > 0);
    }

    public static IEnumerable<int> DigitsFromLeftToRight(this long number)
    {
      //hebt Speicheroptimierung von obiger Methode wieder auf
      return DigitsFromRightToLeft(number).Reverse();
    }
  }
}