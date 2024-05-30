namespace BuildPatternLab
{
    public abstract class DogBuilder
    {
        public abstract void BuildName(string name);
        public abstract void BuildBreed(string breed);
        public abstract void BuildAge(int age);
        public abstract void BuildAddToy(string toy);

        public abstract Dog Build();
    }
}
