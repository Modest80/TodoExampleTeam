using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    public interface ITodo {
        bool SetStatus(bool isComplete);
        void SetTitle(string title);
        void SetDescription(string description);
        void SetStart(DateTime start);
        void SetEnd(DateTime end);
        void SetGiver(IPerson giver);
        void SetTaker(IPerson taker);
    }
}
