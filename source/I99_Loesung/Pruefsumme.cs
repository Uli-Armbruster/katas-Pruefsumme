using System;
using System.Collections.Generic;
using System.Linq;

namespace Pruefsumme.I99_Loesung
{
  public class Pruefsumme
  {
    private readonly int _modulo;
    private readonly Func<long, IEnumerable<int>> _ziffernAusZahl;
    private readonly IEnumerable<int> _gewichtungen;

    public Pruefsumme(Func<long, IEnumerable<int>> ziffernAusZahl,
      IEnumerable<int> gewichtungen,
        int modulo) //Abhängigkeiten
    {
      _ziffernAusZahl = ziffernAusZahl;
      _gewichtungen = gewichtungen;
      _modulo = modulo;
    }

    public int ErzeugeFürGanzzahl(long zahl) //zahl = Parameter
    {
      //Ganzzahl in Ziffern zerlegen
      //Über Ziffern iterieren
      //Multipliziere / Bewerte abwechselnd die Ziffer mit 5 und 1
      //Summe der bewerteten Ziffern bilden
      //Rest der Division 'Summe' durch Parameter

      return _ziffernAusZahl(zahl)
               .Zip(_gewichtungen, (ziffer, gewichtung) => ziffer * gewichtung)
               .Sum()
             % _modulo;
    }
  }
}