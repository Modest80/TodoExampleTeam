using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    [Serializable]
    public abstract class AbstractTodo {
        public string Title { get; set; }
        public bool isComplete { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public AbstractPerson Giver { get; set; }
        public AbstractPerson Taker { get; set; }
        [JsonConstructor]
        public AbstractTodo(string Title, bool isComplete, 
            string Description, DateTime DateStart, DateTime DateEnd, 
            AbstractPerson Giver, AbstractPerson Taker) {
            this.Title = Title;
            this.isComplete = isComplete;
            this.Description = Description;
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.Giver = Giver;
            this.Taker = Taker;
        }
        public AbstractTodo() { }
    }
}
