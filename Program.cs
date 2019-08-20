using System;
public class Program
{

    public static void Main(string[] args)
    {
        
       Console.WriteLine("enter the number ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int row = 1; row <= n; ++row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}