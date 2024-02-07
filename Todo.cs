using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    [Serializable]
    public class Todo : ITodo {
        public string Title { get; set; }
        public bool isComplete { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public IPerson Giver { get; set; }
        public IPerson Taker { get; set; }


        public Todo() {

        }
        public Todo(string title, bool isComplete, string description, DateTime dateStart, DateTime dateEnd, IPerson giver, IPerson taker) {
            Title = title;
            this.isComplete = isComplete;
            Description = description;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Giver = giver;
            Taker = taker;
        }

        public void SetDescription(string description) {
            Description = description;
        }

        public void SetEnd(DateTime end) {
            DateEnd = end;
        }

        public void SetGiver(IPerson giver) {
            Giver = giver;
        }

        public void SetStart(DateTime start) {
            DateStart = start;
        }

        public bool SetStatus(bool isComplete) {
            return false;
        }

        public void SetTaker(IPerson taker) {
            Taker = taker;
        }

        public void SetTitle(string title) {
            Title=title;
        }
        public override string ToString() {
            return $"Название дела: {Title}\n" +
                 $"Описание дела: {Description}\n" +
                 $"Сроки: {DateStart} - {DateEnd}\n" +
                 $"Автор: {Giver}\n" + 
                 $"Исполнитель: {Taker} \n" +
                 $"Статус:" + (isComplete ? "Выполнено" : "Не выполнено") + "\n";
        }
    }
}

