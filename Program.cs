namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете година");
        int num = int.Parse(Console.ReadLine());

            if (num % 4 == 0 && num % 100 != 0 || num % 400 == 0)
           
            {
                Console.WriteLine("Годината е високосна");


            }
            else 
            {
                Console.WriteLine("Годината не е високосна");


            }
        }
    }
}
