using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maga_test
{
    internal class Program
    {
        public static List<Person> persons = new List<Person>();
        static void Main()
        {
            WriteActionList();
            char action = char.Parse(Console.ReadLine().ToLower());
            while (action != 'в')
            {
                switch (action)
                {
                    case 'а':
                        AddPerson();
                        break;
                    case 'п':
                        AllPersons();
                        break;
                    case 'х':
                        WriteActionList();
                        break;
                }
                Console.WriteLine();
                action = char.Parse(Console.ReadLine().ToLower());
            }
            
            Console.ReadKey();
        }

        static void WriteActionList()
        {
            Console.WriteLine("А - добавить пользователя");
            Console.WriteLine("П - показать всех пользователей");
            Console.WriteLine("Х - лист действий");
            Console.WriteLine("В - выход");
        }

        static void AllPersons()
        {
            Console.WriteLine("Список пользователей: ");
            Console.WriteLine("Фамилия || Имя || Дата рождения || Возраст");
            foreach (Person person in persons)
            { 
                Console.WriteLine(person.Print());
            }
        }


        static void AddPerson()
        {
            try
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Write("Фамилия: ");
                string firstname = Console.ReadLine();
                Console.Write("Дата рождения (день.месяц.год): ");
                DateTime dateTime = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Пользователь успешно добавлен!");
                Person person = new Person(name, firstname, dateTime);
                persons.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

}
