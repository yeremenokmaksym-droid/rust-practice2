// https://www.hackerrank.com/challenges/simple-array-sum/problem
using System;

class Solution { static void Main() { int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j < n - i; j++)
            Console.Write(" ");

        for (int j = 0; j < i; j++)
            Console.Write("#");

        Console.WriteLine();
    }
}
