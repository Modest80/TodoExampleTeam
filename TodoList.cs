using System;
using System.Collections.Generic;

namespace TodoExampleTeam {
    [Serializable]
    public class TodoList {
        private List<Todo> _todos;
        private List<IPerson> _person;
        public void ShowTodos() {

        }
        public bool ContainPerson(IPerson person) {
            return false;
        }
        public bool AddPerson(IPerson person) {
            return false;
        }
        public bool RemovePerson(IPerson person) {
            return false;
        }
        public bool AddTodo(Todo todo) {
            return false;
        }
        public bool RemoveTodo(Todo todo) {
            return false;
        }
        public bool SaveList(string path) {
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
            return false;
        }
    }
}
