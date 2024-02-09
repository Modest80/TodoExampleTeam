using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    public partial class TodoList {
        public bool SaveList(string path) {
            string json = JsonSerializer.Serialize(Todos);
            File.WriteAllText(path, json);
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
            string Json = File.ReadAllText(path);
            Todos = JsonSerializer.Deserialize<List<AbstractTodo>>(Json);
            return false;
        }

    }
}
