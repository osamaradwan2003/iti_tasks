namespace Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(checkODD(15));
      Console.WriteLine(checkTall(135));
      Console.WriteLine(maxNumber(25, 63, 10));
    }
    static string checkODD(int number)
    {
      return number % 2 != 0 ? number + " is Odd number" : number + "not odd number";
    }
    static string checkTall(int number)
    {
      return number > 180 ? number + " is tall" : number + "is Dwarf";
    }
    static int maxNumber(int number1, int number2, int number3)
    {
      return Math.Max(number1, Math.Max(number2, number3));
    }
  }
}
