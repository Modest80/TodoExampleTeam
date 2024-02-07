using System;
using System.Collections.Generic;

namespace TodoExampleTeam {
    [Serializable]
    public class TodoList {
        public List<AbstractTodo> Todos { get; private set; }
        private List<AbstractPerson> _person;
        public TodoList() {
            Todos = new List<AbstractTodo>();
            _person = new List<AbstractPerson>();
        }
        public void ShowTodos() {
            int i = 1;
            foreach (var todo in Todos) {
                Console.WriteLine($"{i++}. {todo}");
            }
        }
        public void ShowTodos(AbstractPerson user) {
            int i = 1;
            foreach (var todo in Todos) {
                if (user.Name == todo.Giver.Name && 
                    user.Name == todo.Taker.Name) {
                Console.WriteLine($"{i++}. {todo}");
                }
            }
        }
        public bool ContainPerson(AbstractPerson person) {
            return _person.Contains(person);
        }
        public bool AddPerson(AbstractPerson person) {
            _person.Add(person);
            return true;
        }
        public bool RemovePerson(AbstractPerson person) {
            return _person.Remove(person);
        }
        public bool AddTodo(AbstractTodo todo) {
            Todos.Add(todo);
            return true;
        }
        public bool RemoveTodo(AbstractTodo todo) {
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
