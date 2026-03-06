using System;

class Program
{
    static void Main(string[] args)
    {
        Addition add = new Addition();
        add.DoAddition(2,3);

        Subtraction sub = new Subtraction();
        sub.DoSubtraction(5,2);

        Multiplication mul = new Multiplication();
        mul.DoMultiplication(2,3);
    }
}