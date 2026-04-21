using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int getTotalX(List<int> a, List<int> b)
    {
        int lcmA = a[0];
        foreach (int i in a)
        {
            lcmA = getLCM(lcmA, i);
        }

        int gcdB = b[0];
        foreach (int i in b)
        {
            gcdB = getGCD(gcdB, i);
        }

        int count = 0;
        int multiple = lcmA;
        while (multiple <= gcdB)
        {
            if (gcdB % multiple == 0)
            {
                count++;
            }
            multiple += lcmA;
        }

        return count;
    }

    private static int getGCD(int n1, int n2)
    {
        while (n2 != 0)
        {
            int temp = n1 % n2;
            n1 = n2;
            n2 = temp;
        }
        return n1;
    }

    private static int getLCM(int n1, int n2)
    {
        if (n1 == 0 || n2 == 0) return 0;
        return Math.Abs(n1 * n2) / getGCD(n1, n2);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        TextWriter textWriter = new StreamWriter(outputPath, true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
