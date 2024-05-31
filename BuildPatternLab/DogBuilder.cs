namespace BuildPatternLab
{
    public abstract class DogBuilder
    {
        public abstract DogBuilder BuildName(string name);
        public abstract DogBuilder BuildBreed(string breed);
        public abstract DogBuilder BuildAge(int age);
        public abstract DogBuilder BuildAddToys(List<string> toys);

        public abstract Dog GetDog();
    }
}
