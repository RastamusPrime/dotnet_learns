using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {

      var book = new Book();
      book.AddGrade(89.1);

      var grades = new List<double>() { 12.7, 10.3, 15.1, 10.6, 4.6 };

      var avgTotal = 0.0;
      foreach (var grade in grades)
      {
        avgTotal += grade;
      }

      avgTotal /= grades.Count;
      Console.WriteLine($"The average grade is {avgTotal:N1}");
    }
  }
}