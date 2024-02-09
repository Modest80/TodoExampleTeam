﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    public abstract class AbstractTodo {
        public string Title { get; set; }
        public bool isComplete { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public AbstractPerson Giver { get; set; }
        public AbstractPerson Taker { get; set; }
    }
}
