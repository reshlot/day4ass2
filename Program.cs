using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4exer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter User Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                string pwd = Console.ReadLine();
                if (name == "reshma" && pwd == "2417")
                {
                    Console.WriteLine("Login Successfull");
                }
                else if (name != "reshma")
                {
                    Console.WriteLine("Invalid UserName");
                }
                else if (pwd != "2417")
                {
                    Console.WriteLine("Invalid Password");
                }
                else if (name == "reshma" && pwd != "2417")
                {
                    Console.WriteLine("Invalid Password.");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Login Failed");
            Console.ReadKey();
        }
    }
}
