namespace BuildPatternLab
{   
    public class ConcreteDogBuilder : DogBuilder
    {
        private readonly Dog _dog;

        public ConcreteDogBuilder()
        {
            _dog = new Dog();
        }
        public override DogBuilder BuildName(string name)
        {
            _dog.Name = name;
            return this;
        }

        public override DogBuilder BuildAge(int age)
        {
            _dog.Age = age;
            return this;
        }

        public override DogBuilder BuildBreed(string breed)
        {
            _dog.Breed = breed;
            return this;
        }

        public override DogBuilder BuildAddToys(List<string> toys)
        {
            if (_dog.Toys == null)
            {
                _dog.Toys = new List<string>(toys);
            }
            _dog.Toys.AddRange(toys);
            
            return this;
        }

        public override Dog GetDog()
        {
            return _dog;
        }
    }
}
