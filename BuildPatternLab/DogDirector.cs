namespace BuildPatternLab
{
    public class DogDirector
    {
        private DogBuilder _dogBuilder;
        public DogDirector(DogBuilder dogBuilder) {
            _dogBuilder = dogBuilder;
        }

        public void ConstructDog(string name, string breed, int age, List<string> toys) 
        {
            _dogBuilder.BuildName(name);
            _dogBuilder.BuildBreed(breed);
            _dogBuilder.BuildAge(age);
            _dogBuilder.BuildAddToys(toys);
        }

        public string GetDog()
        {
            return _dogBuilder.GetDog().ToString();
        }
    }
}
