using System;
using System.Net;

namespace Pruefsumme.I99_Loesung
{
  //Value Object
  // ReSharper disable once InconsistentNaming
  public class IPv4Address
  {
    private readonly IPAddress _ip;

    public IPv4Address(string ip)
    {
      if (!IPAddress.TryParse(ip, out var validIpAddress))
        throw new ArgumentOutOfRangeException(nameof(ip), "no valid IPv4 address");

      _ip = validIpAddress;
    }

    public static IPv4Address Localhost()
    {
      return new IPv4Address("127.0.0.1");
    }

    public long AsNumber()
    {
      var ipAsNumber = _ip
        .ToString()
        .Replace(".", string.Empty);

      return long.Parse(ipAsNumber);
    }

    //Alternative zu AsNumber
    public static implicit operator long(IPv4Address currentObject)
    {
      var ipAsNumber = currentObject._ip
        .ToString()
        .Replace(".", string.Empty);

      return long.Parse(ipAsNumber);
    }
  }
}