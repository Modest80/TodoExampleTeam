using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    internal class Program {
        public const string filepath = "todos.json";
        public const string filepathPersons = "persons.json";
        static void Main(string[] args) {
            TodoList todos = new TodoList();
            todos.LoadPersons(filepathPersons);
            todos.LoadList(filepath);

            string username = "";
            Console.Write("Ваше имя: ");
            username = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();            
            
            Person user = new Person() {
                Name = username,
            };
            user.SetPassword(password);
            if (!todos.ContainPerson(user)) {
                string position = "";
                Console.Write("Ваша должность: ");
                position = Console.ReadLine();
                user.SetPosition(position);
                todos.AddPerson(user);
            } else {
                while (!todos.CheckPerson(user)) {
                    Console.Write("Пароль: ");
                    password = Console.ReadLine();
                    user.SetPassword(password);
                }
            }
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (key.Key != ConsoleKey.Escape) {
                Console.Clear();
                ShowMenu();
                key = Console.ReadKey();
                Console.Clear();
                switch (key.Key) {
                    case ConsoleKey.D1:
                        //Общий список дел
                        todos.ShowTodos();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        //Мой список дел
                        todos.ShowTodos(user);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D3:
                        //Логика заполнения дела
                        //Название дела
                        Console.Write("Название дела: ");
                        string title = Console.ReadLine();
                        Console.Write("Описание дела: ");
                        string description=Console.ReadLine();
                        var todo = new Todo() {
                            Title = title,
                            Description = description,
                            Giver = user
                        };
                        todos.AddTodo(todo);
                        break;
                    case ConsoleKey.D4:
                        //Удалить дело
                        break;
                    case ConsoleKey.D5:
                        //Найти дело:
                        // по названию,
                        // по автору/исполнителю
                        // по дате начала/окончания
                        break;
                    case ConsoleKey.D6:
                        //Взять дело в работу
                        todos.ShowOpenTodos();
                        try {
                            int todoNumber = Int32.Parse(Console.ReadLine());
                            //todos.TakeTodo(todoNumber, user);
                        } catch { 
                        
                        }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D7:
                        //Завершить дело
                        //todos.ShowWorkTodos(user);
                        break;
                }                
            }

            todos.SaveList(filepath);
            todos.SavePersons(filepathPersons);
        }
        public static void ShowMenu() {
            Console.WriteLine(" ---- Список дел -----");
            Console.WriteLine("\t1.Общий список дел");
            Console.WriteLine("\t2.Мой список дел");
            Console.WriteLine("\t3.Добавить дело");
            Console.WriteLine("\t4.Удалить дело");
            Console.WriteLine("\t5.Найти дело");
            Console.WriteLine("\t6.Взять дело");
            Console.WriteLine("\t7.Завершить дело\n");
            Console.WriteLine("\tESC.Выход");
        }
    }
}
