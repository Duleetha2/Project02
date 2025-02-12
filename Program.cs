namespace Project02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            //Inputs
            Console.Write("Enter First Number :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number :");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Addition
            result = num1 + num2;
            Console.WriteLine("Addition :" + result);

            //Substraction
            result = num1 - num2;
            Console.WriteLine("Substraction :" + result);

            Console.ReadLine();
        }
    }
}
