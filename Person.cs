using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    [Serializable]
    public class Person : IPerson {
        public string Name;
        public string Position;

        public void SetName(string name) {
            Name = name;
        }

        public void SetPosition(string position) {
            Position = position;
        }
    }

}
