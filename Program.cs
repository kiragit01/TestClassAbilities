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
                    case 'у':
                        DeletePersons();
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
            Console.WriteLine("У - удалить пользователя");
            Console.WriteLine("Х - лист действий");
            Console.WriteLine("В - выход");
            Console.WriteLine();
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


        static void DeletePersons()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine($"{i+1}. {persons[i].FirstName} {persons[i].Name}");
            }
            Console.Write("Введите номер пользователя, которого хотите удалить: ");
            int num = int.Parse(Console.ReadLine()) - 1;
            persons.RemoveAt(num);
            Console.WriteLine("Пользователь успешно удалён!");
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
                string date = Console.ReadLine();
                while(!DateTime.TryParse(date, out DateTime datetime))
                {
                    Console.WriteLine("Дата введена неверно. Введите заново.");
                    Console.Write("Дата рождения (день.месяц.год): ");
                    date = Console.ReadLine();
                }
                DateTime dateTime = DateTime.Parse(date);
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
