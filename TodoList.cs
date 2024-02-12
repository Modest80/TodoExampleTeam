using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TodoExampleTeam {
    [Serializable]
    public partial class TodoList {
        public List<AbstractTodo> Todos { get; protected set; }
        public List<AbstractPerson> Persons { get; protected set; }
        public TodoList() {
            Todos = new List<AbstractTodo>();
            Persons = new List<AbstractPerson>();
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
                if (user.Name == todo.Giver.Name ||
                    (todo.Taker != null && 
                     user.Name == todo.Taker.Name)) {
                    Console.WriteLine($"{i++}. {todo}");
                }
            }
        }
        public void ShowOpenTodos() {
            int i = 1;
            foreach (var todo in Todos) {
                if (todo.isComplete == false && todo.Taker == null) {
                    Console.WriteLine($"\t{i++}. {todo.Title}");
                }
            }
        }
        public bool ContainPerson(AbstractPerson person) {
            foreach (var user in Persons) {
                if (user.Name == person.Name) {
                    return true;
                }
            }
            return false;
        }
        public bool AddPerson(AbstractPerson person) {
            Persons.Add(person);
            return true;
        }
        public bool RemovePerson(AbstractPerson person) {
            return Persons.Remove(person);
        }
        public bool AddTodo(AbstractTodo todo) {
            Todos.Add(todo);
            return true;
        }
        public bool RemoveTodo(AbstractTodo todo) {
            return Todos.Remove(todo);
        }
        public bool SavePersons(string filepath) {
            string json = JsonSerializer.Serialize(Persons);
            File.WriteAllText(filepath, json);
            return true;
        }
        public bool LoadPersons(string filepath) {
            if (!File.Exists(filepath)) { return false; }
            string Json = File.ReadAllText(filepath);
            List<Person> persons = null;
            try {
                persons = JsonSerializer.Deserialize<List<Person>>(Json);
                Persons.AddRange(persons);
            } catch (Exception ex) {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            return false;
        }
        public bool CheckPerson(AbstractPerson user) { 
            foreach (var person in Persons) {
                Console.WriteLine($"user:{user.Password} - person:{person.Password}");
                if (user.Name == person.Name && 
                    user.Password == person.Password) { 
                    return true;
                }
            }
            return false;
        }
        public void TakeTodo(int todoNumber, AbstractPerson user) {
            if(todoNumber>=1 && todoNumber<=Todos.Count+1) {
                if (Todos[todoNumber - 1].Taker == null) {
                    Todos[todoNumber-1].Taker = user;
                    Todos[todoNumber-1].DateStart = DateTime.Now;
                }
            }
        }
    }
}
