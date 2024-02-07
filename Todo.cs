using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    [Serializable]
    public class Todo : AbstractTodo {

        public Todo() {
        }
        public Todo(string title, bool isComplete, 
            string description, DateTime dateStart, 
            DateTime dateEnd, AbstractPerson giver, AbstractPerson taker) {
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

        public void SetGiver(AbstractPerson giver) {
            Giver = giver;
        }

        public void SetStart(DateTime start) {
            DateStart = start;
        }

        public bool SetStatus(bool isComplete) {
            return false;
        }

        public void SetTaker(AbstractPerson taker) {
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

