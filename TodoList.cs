using System;
using System.Collections.Generic;

namespace TodoExampleTeam {
    [Serializable]
    public class TodoList {
        private List<Todo> _todos;
        private List<IPerson> _person;
        public void ShowTodos() {
            int i = 1;
            foreach (var todo in _todos) {
                Console.WriteLine($"{i++}. {todo}");
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
        public bool AddTodo(Todo todo) {
            _todos.Add(todo);
            return true;
        }
        public bool RemoveTodo(Todo todo) {
            return _todos.Remove(todo);
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
