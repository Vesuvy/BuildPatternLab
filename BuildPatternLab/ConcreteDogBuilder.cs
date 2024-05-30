using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPatternLab
{   
    internal class ConcreteDogBuilder : DogBuilder
    {
        private Dog _dog = new();
        public override void BuildName(string name)
        {
            _dog.Name = name;
        }

        public override void BuildAge(int age)
        {
            
        }

        public override void BuildBreed(string breed)
        {

        }

        public override void BuildAddToy(string toy)
        {
            
        }

        public override Dog Build()
        {
            return _dog;
        }
    }
}
