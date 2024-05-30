using System.Text;

namespace BuildPatternLab
{
    public class Dog
    {
        private string? Name;
        public string? Breed { get; private set; }
        public int Age { get; private set; }
        public List<string>? Toys { get; private set; }
        public override string ToString() {
            return new StringBuilder()
            .Append(Name)
            .Append(Breed)
            .Append(Age)
            .Append(Toys)
            .ToString();
        }
    }
}
