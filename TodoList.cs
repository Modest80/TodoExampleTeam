using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    public class TodoList {
        private List<Todo> _todos;
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
