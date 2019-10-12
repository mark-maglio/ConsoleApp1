using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cosa mi vuoi chiedere?");
            string risposta = Console.ReadLine();
            foreach (char a in risposta)
            {
                string s = "ABCD";
                byte[] bytes = Encoding.ASCII.GetBytes(risposta);
                int result = BitConverter.ToInt32(bytes, 0);
            }
        }
    }
}
