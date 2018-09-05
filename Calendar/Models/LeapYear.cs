using System;
using Calendar;

namespace Calendar
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year % 100 == 0)
      {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }
    }
  }
}
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Please enter the year.");
    int enteredYear = int.Parse(Console.ReadLine());
    LeapYear myLeapYear = new LeapYear();
    Console.WriteLine(myLeapYear.IsLeapYear(enteredYear));
  }
}
