﻿Console.WriteLine("Math Functions");
//      console.writeline("enter an x: ");
//      int x = int.parse(console.readline());
//      console.writeline("enter y: ");
//      int y = int.parse(console.readline());
//      int z = x + y;
//      console.writeline("sum of " ,x , " + " , y , " = " , z);
double resultOfRound = Math.Round(3.14);
Console.WriteLine("Round" + " " + resultOfRound);
double resultOfMax = Math.Max(78547, 4512);
Console.WriteLine("MAX" + " " + resultOfMax);
double resultOfMin = Math.Min(78547, 4512);
Console.WriteLine("Min", " ", resultOfMin);
double resultOfAbs = Math.Abs(-3.14);
Console.WriteLine("Absolute Value" + " " + resultOfAbs);
Console.Write("Enter an angle(to calculate it's sin,cos,tan,ctan) : ");
double angle = int.Parse(Console.ReadLine());
Console.WriteLine("Sin of {0} is {1}", angle, Math.Sin(angle));
Console.WriteLine("Cos of {0} is {1}", angle, Math.Cos(angle));
Console.WriteLine("Tan of {0} is {1}", angle, Math.Tan(angle));
Console.WriteLine("Tan of {0} is {1}", angle, 1 / Math.Tan(angle));
Console.Write("Enter a value (to calculate it's arcsin,arccos,arctan,arcctg) : ");
double value = int.Parse(Console.ReadLine());
Console.WriteLine("The angle of sin({0}) is {1}", value, Math.Asin(value));
Console.WriteLine("The angle of cos({0}) is {1}", value, Math.Acos(value));
Console.WriteLine("The angle of tan({0}) is {1}", value, Math.Atan(value));
Console.WriteLine("Tan of {0} is {1}", angle, 1 / Math.Atan(value));

