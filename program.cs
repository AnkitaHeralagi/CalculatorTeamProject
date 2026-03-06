using System;

class Program
{
    public class Addition
    {
        public int DoAddition(int a, int b)
        {
            return a + b; 
        }
    }

    public class Subtraction
    {
        public int DoSubtraction(int a, int b)
        {
            return a - b;
        }
    }

    static void Main(string[] args)
    {
        Addition add = new Addition();
        Console.WriteLine(add.DoAddition(2,3));

        Subtraction sub = new Subtraction();
        Console.WriteLine(sub.DoSubtraction(5,2));

        Multiplication mul = new Multiplication();
        mul.DoMultiplication(2,3);
    }
}

class Multiplication
{
    public void DoMultiplication(int a , int b)
    {
        Console.WriteLine(a*b);
    }
}
