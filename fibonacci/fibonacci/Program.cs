﻿using System;
public class FibonacciExample
{
    public static void Main(string[] args)
    {
        int a = 0, b = 1, c, i, number;
        Console.Write("Enter the number of elements: ");
        number = int.Parse(Console.ReadLine());
        Console.Write(a + " " + b + " "); //printing 0 and 1    
        for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}