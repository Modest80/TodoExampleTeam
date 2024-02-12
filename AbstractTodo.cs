using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    public abstract class AbstractTodo {
        public AbstractTodo(string title, bool isComplete, string description, DateTime dateStart, DateTime dateEnd, AbstractPerson giver, AbstractPerson taker) {
            Title = title;
            this.isComplete = isComplete;
            Description = description;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Giver = giver;
            Taker = taker;
        }

        public string Title { get; set; }
        public bool isComplete { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public AbstractPerson Giver { get; set; }
        public AbstractPerson Taker { get; set; }
    }
}
