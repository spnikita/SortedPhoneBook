using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedPhoneBook
{
    class Program
    {
        /// <summary>
        /// Телефонная книга
        /// </summary>
        private static readonly List<Contact> _phoneBook = new List<Contact>
        {
            new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
            new Contact("Сергей", "Довлатов",79990000010, "serge@example.com"),
            new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
            new Contact("Валерий", "Леонтьев",79990000012, "valera@example.com"),
            new Contact("Сергей", "Брин",  799900000013, "serg@example.com"),
            new Contact("Иннокентий", "Смоктуновский",799900000013, "innokentii@example.com")
        }.OrderBy(contact => contact.Name).ThenBy(contact => contact.LastName).ToList();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите номер страницы: ");

                var input = Console.ReadKey().KeyChar;

                var parsed = int.TryParse(input.ToString(), out int pageNumber);

                if (!parsed || pageNumber < 1 || pageNumber > 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Страницы не существует");
                }
                else
                {
                    var pageContent = _phoneBook.Skip((pageNumber - 1) * 2).Take(2);
                    Console.WriteLine();

                    foreach (var entry in pageContent)
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);
                }

                Console.Write("Для выхода нажмите 'x': ");

                var exitChar = Console.ReadKey().KeyChar;
                if (exitChar.Equals('x'))
                    break;

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
