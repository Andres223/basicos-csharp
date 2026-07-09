using System.Security.Cryptography;

partial class Program
{
  static void GeneratedOtp()
  {
    var otp = RandomNumberGenerator.GetInt32(100000, 1000000);
    Console.WriteLine(otp);
  }
}