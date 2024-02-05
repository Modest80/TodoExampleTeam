using System.Collections.Generic;

namespace TodoExampleTeam {
    public class TodoList {
        private List<Todo> _todos;
        private List<IPerson> _person;
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
        public bool LoadList(string path) {
            return false;
        }
    }
}
