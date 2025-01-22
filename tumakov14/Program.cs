using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Console.WriteLine("Введите что-либо для для выхода...");
            Console.ReadKey();
        }
        /// <summary>
        /// Упражнение 14.1
        /// </summary>
        private static void Task1()
        {
            Bank1 bank = new Bank1();
            bank.DumpToScreen();
        }
        /// <summary>
        /// Упражнение 14.2
        /// </summary>
        private static void Task2()
        {
            foreach (Attribute a in typeof(RationalNumber).GetCustomAttributes(false))
            {
                if (a is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute attribute = a as DeveloperInfoAttribute;
                    Console.WriteLine($"девелопер: {attribute.DeveloperName}, дата: {attribute.DevelopmentDate}");
                }
            }
        }
        /// <summary>
        /// Домашнее задание 14.1
        /// </summary>
        private static void Task3()
        {
            var attributes = typeof(Bank1).GetCustomAttributes(typeof(AccountInfoAttribute), false);
            if (attributes.Length > 0)
            {
                var accountInfoAttribute = (AccountInfoAttribute)attributes[0];
                Console.WriteLine($"девелопер: {accountInfoAttribute.DeveloperName}");
                Console.WriteLine($"организейшан: {accountInfoAttribute.OrganizationName}");
            }
            else
            {
                Console.WriteLine("атрибуты не найдены.");
            }
        }
    }
}
