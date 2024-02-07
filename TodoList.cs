using System;
using System.Collections.Generic;

namespace TodoExampleTeam {
    [Serializable]
    public class TodoList {
        public List<ITodo> Todos { get; private set; }
        private List<IPerson> _person;
        public TodoList() {
            Todos = new List<ITodo>();
            _person = new List<IPerson>();
        }
        public void ShowTodos() {
            int i = 1;
            foreach (var todo in Todos) {
                Console.WriteLine($"{i++}. {todo}");
            }
        }
        public void ShowTodos(IPerson user) {
            int i = 1;
            foreach (var todo in Todos) {
                if (user.Name == todo.Giver && user.Name == todo.Taker) {
                Console.WriteLine($"{i++}. {todo}");
                }
            }
        }
        public bool ContainPerson(IPerson person) {
            return _person.Contains(person);
        }
        public bool AddPerson(IPerson person) {
            _person.Add(person);
            return true;
        }
        public bool RemovePerson(IPerson person) {
            return _person.Remove(person);
        }
        public bool AddTodo(ITodo todo) {
            Todos.Add(todo);
            return true;
        }
        public bool RemoveTodo(ITodo todo) {
            return Todos.Remove(todo);
        }
        public bool SaveList(string path) {
            // сохранение дел


            // сохранение персон
            return false;
        }
        /// <summary>
        /// Загружает все дела
        /// </summary>
        /// <param name="path">
        /// Путь к файлу с делами
        /// </param>
        /// <returns></returns>
        public bool LoadList(string path) {
            // загрузка персон

            // загрузка дел
            return false;
        }
    }
}
