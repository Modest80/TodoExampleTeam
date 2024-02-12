using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using TodoExampleTeam;

namespace TodoExampleTeam {
    public partial class TodoList {
        public bool SaveList(string path) {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.Converters.Add(new AbsTodoConvertor());
            string json = JsonSerializer.Serialize(Todos, options);
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
            if (File.Exists(path)) {
                var options = new JsonSerializerOptions();
                options.Converters.Add(new AbsTodoConvertor());
                string json = File.ReadAllText(path);
                Todos = JsonSerializer.Deserialize<List<AbstractTodo>>(json, options);
            }
            return true;
            /*
            string Json = File.ReadAllText(path);
            List<Todo> todos = new List<Todo>();
            try {
                todos = JsonSerializer.Deserialize<List<Todo>>(Json);
                Todos.AddRange(todos);
            } catch (Exception ex) {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            return false;
            */
        }

    }
}
public class AbsPersonConvertor : JsonConverter<AbstractPerson> {
    public override AbstractPerson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        using (JsonDocument jsonD = JsonDocument.ParseValue(ref reader)) {
            JsonElement root = jsonD.RootElement;
            string name = root.GetProperty("Name").GetString();
            string pos = root.GetProperty("Position").GetString();
            string pass = root.GetProperty("Password").GetString();
            return new Person(name, pos, pass);
        }
    }
    public override void Write(Utf8JsonWriter writer, AbstractPerson value, JsonSerializerOptions options) {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
public class AbsTodoConvertor : JsonConverter<AbstractTodo> {
    public override AbstractTodo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        using (JsonDocument jsonD = JsonDocument.ParseValue(ref reader)) {
            JsonElement root = jsonD.RootElement;
            string title = root.GetProperty("Title").GetString();
            bool isCom = root.GetProperty("isComplete").GetBoolean();
            string desc = root.GetProperty("Description").GetString();
            DateTime DateS = root.GetProperty("DateStart").GetDateTime();
            DateTime DateE = root.GetProperty("DateEnd").GetDateTime();
            string giverName = root.GetProperty("Giver").GetProperty("Name").GetString();
            string giverPos = root.GetProperty("Giver").GetProperty("Position").GetString();
            string giverPass = root.GetProperty("Giver").GetProperty("Password").GetString();
            AbstractPerson giver = new Person(giverName, giverPos, giverPass);
            if (root.GetProperty("Taker").GetString() != null) {
                string takerName = root.GetProperty("Taker").GetProperty("Name").GetString();
                string takerPos = root.GetProperty("Taker").GetProperty("Position").GetString();
                string takerPass = root.GetProperty("Taker").GetProperty("Password").GetString();

                return new Todo(title, isCom, desc, DateS, DateE, giver, new Person(takerName, takerPos, takerPass));
            }
            return new Todo(title, isCom, desc, DateS, DateE, giver, null);
        }
    }
    public override void Write(Utf8JsonWriter writer, AbstractTodo value, JsonSerializerOptions options) {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}