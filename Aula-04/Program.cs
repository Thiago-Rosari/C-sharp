namespace Aula_04
{
    internal class Program
    {
         int num = 10;     // variável global

        static void Main()
        {
            int num2 = 0;    // variável local
            Console.WriteLine(num2);
        }

        private void Test()
        {
            Console.Write(num);
        }
    }
}