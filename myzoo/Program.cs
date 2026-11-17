using myzoo;

dog Dog = new dog() { Name = "Humus" , Weight = 5 };
Cat cat = new Cat() { Name = "pita" , Weight = 4 };
Donkey donkey = new Donkey() { Name = "schog" , Weight = 100};

List<Animel> animels = new List<Animel>() { Dog, cat, donkey };
foreach (var animel in animels)
{
    Console.WriteLine(animel.SayHello());
    Thread.Sleep(1000);

}
