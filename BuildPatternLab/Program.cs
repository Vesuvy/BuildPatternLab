using BuildPatternLab;

DogBuilder builder = new ConcreteDogBuilder();
DogDirector director = new DogDirector(builder);
director.ConstructDog("Рекс", "Терьер", 10, ["мяч", "кость"]);
// Первая собака
Console.WriteLine("dog1:");
Dog dog1 = builder.GetDog();
Console.WriteLine(director.GetDog());
// Первая собака
Console.WriteLine("dog1 (добавление игрушки):");
builder.BuildAddToys(["палка"]);
Console.WriteLine(director.GetDog());

// Вторая собака
builder.BuildName("Боб")
    .BuildBreed("Дворняга")
    .BuildAge(5)
    .BuildAddToys(["бутылка", "палка", "шарф"]);
Dog dog2 = builder.GetDog();
Console.WriteLine("dog2:\n" + dog2);

// Третья собака
builder.BuildName("Пудж")
    .BuildBreed("Овчарка")
    .BuildAge(5)
    .BuildAddToys(["крюк", "шапка", "деньги"]);
Dog dog3 = builder.GetDog();
Console.WriteLine("dog3:\n" + dog3);



