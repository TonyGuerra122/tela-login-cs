using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLoginGUI {
    class Person {
        protected string Name;
        
        public Person(string name) {
            this.Name = name;
        }
        public string GetName() {
            return this.Name;
        }
        public void SetName(string name) {
            this.Name = name;
        }
    }
}
