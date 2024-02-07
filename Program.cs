using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    internal class Program {
        public const string filepath = "todos.json";
        static void Main(string[] args) {
            string username = "";
            Console.Write("Ваше имя: ");
            username = Console.ReadLine();
            TodoList todos = new TodoList();
            todos.LoadList(filepath);
            Person user = new Person() {
                Name = username,
            };
            if (!todos.ContainPerson(user)) {
                string position = "";
                Console.Write("Ваша должность: ");
                position = Console.ReadLine();
                user.SetPosition(position);
                todos.AddPerson(user);
            }
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (key.Key != ConsoleKey.Escape) {
                Console.Clear();
                ShowMenu();
                key = Console.ReadKey();
                switch (key.Key) {
                    case ConsoleKey.D1:
                        //Общий список дел
                        todos.ShowTodos();
                        break;
                    case ConsoleKey.D2:
                        //Мой список дел
                        todos.ShowTodos(user);
                        break;
                    case ConsoleKey.D3:
                        var todo = new Todo();
                        //Логика заполнения дела
                        //Название дела
                        Console.WriteLine("Название дела");
                        string title = Console.ReadLine();
                        //Описание дела
                        
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
                }                
            }


            todos.SaveList(filepath);
        }
        public static void ShowMenu() {
            Console.WriteLine(" ---- Список дел -----");
            Console.WriteLine("\t1.Общий список дел");
            Console.WriteLine("\t2.Мой список дел");
            Console.WriteLine("\t3.Добавить дело");
            Console.WriteLine("\t4.Удалить дело");
            Console.WriteLine("\t5.Найти дело\n");
            Console.WriteLine("\tESC.Выход");
        }
    }
}
