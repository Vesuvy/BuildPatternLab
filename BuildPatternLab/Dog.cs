using System.Text;

namespace BuildPatternLab
{
    public class Dog
    {
        private string? _name;
        private string? _breed;
        private int? _age;
        private List<string>? _toys;
        
        public string? Name {
            get => _name;
            set => _name = value;
        }
        public string? Breed {
            get => _breed;
            set => _breed = value;
        }
        public int? Age {
            get => _age;
            set => _age = value;
        }
        public List<string>? Toys {
            get => _toys; 
            set => _toys = value;
        }

        public override string ToString() {
            return new StringBuilder()
            .Append("Имя:" + Name + "\n")
            .Append("Порода:" + Breed + "\n")
            .Append("Возраст:" + Age + "\n")
            .Append("Игрушки:" + string.Join(", ", Toys) + "\n")
            .ToString();
        }
    }
}
