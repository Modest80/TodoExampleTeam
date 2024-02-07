using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    [Serializable]
    public class Person : AbstractPerson {
        
        public void SetName(string name) {
            Name = name;
        }

        public void SetPosition(string position) {
            Position = position;
        }
        public override string ToString() {
            return $"{Name} ({Position})";
        }
    }

}
