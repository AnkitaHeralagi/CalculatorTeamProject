using System;

class Program
{
<<<<<<< Updated upstream
=======
    public class Addition{
        public void DoAddition(int a, int b)
        {
             Console.WriteLine(a + b);// adding to numbers
        }
    }
>>>>>>> Stashed changes
    public class Subtraction{
        public void DoSubtraction(int a, int b){
            Console.WriteLine(a - b);
        }
    }
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