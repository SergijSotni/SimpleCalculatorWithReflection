namespace SimpleCalculatorWithReflection
{
    //Клас з математичними операціями
    static class Calculator
    {
        [Operation("+")]
        static public void Add(int a, int b) { Console.WriteLine(a + b); }

        [Operation("-")]
        static public void Subtraction(int a, int b) { Console.WriteLine(a - b); }

        [Operation("*")]
        static public void Multiply(int a, int b) { Console.WriteLine(a * b); }

        [Operation("/")]
        static public void Divide(int a, int b) { Console.WriteLine(a / b); }
    }
}
