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
    }
}

