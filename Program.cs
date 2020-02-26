using System;
using PrimeSifting.Models;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class Program 
{

  public static Prime prime = new Prime();
  public static void Main()
  {
    Console.WriteLine("Enter a number");
    int number = int.Parse(Console.ReadLine());
    List<int> nums = prime.SiftNumbers(prime.CreateNumbersBetween(number),2,0,1);
    StringBuilder sb = new StringBuilder();
    foreach (int num in nums){
      sb.Append(num + " ");
    }
    Console.WriteLine("Your prime numbers are: " + sb.ToString());
    Console.ReadLine();
  }
}