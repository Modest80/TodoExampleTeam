using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    [Serializable]
    public class Person : AbstractPerson, IPerson {
        public Person() {}
        public Person(string name,string pos,string pass) : base(name, pos, pass) {
        
        }
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
