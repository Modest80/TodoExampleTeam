using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    internal class Todo : ITodo {
        string Title;
        bool isComplete;
        string Description;
        DateTime DateStart;
        DateTime DateEnd;
        IPerson Giver;
        IPerson Taker;

        public void SetDescription(string description) {
            
        }

        public void SetEnd(DateTime end) {
            
        }

        public void SetGiver(IPerson giver) {
            
        }

        public void SetStart(DateTime start) {
            
        }

        public bool SetStatus(bool isComplete) {
            return false;
        }

        public void SetTaker(IPerson taker) {
            
        }

        public void SetTitle(string title) {
            
        }
    }
}

