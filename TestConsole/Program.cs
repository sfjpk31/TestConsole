namespace TRServiceClient
{
    using System;
    using TestConsole;

    class Program
    {
        static void Main(string[] args)
        {
            TestService();

            Console.WriteLine("Th-th-that's all, folks!");
            Console.ReadLine();
        }

        private static void TestService()
        {
            var zoo = new List<Animal>();

            var catNew = new FelineAnimal();
            var dogNew = new CanineAnimal();
            var animalNew = new Animal();

            zoo.Add(catNew);
            zoo.Add(dogNew);
            zoo.Add(animalNew);

            foreach (var animal in zoo)
            {
                if ("Cat" == animal.Name)
                {
                    var cat = animal as FelineAnimal;
                    if (null != cat)
                    {
                        Console.WriteLine($"<Feline> {cat.Name} speaks: {cat.Speak()}");
                        Console.WriteLine($"{cat.Name} hisses: {cat.Hiss()}");
                    }
                    else
                    {
                        Console.WriteLine("Null cat");
                    }
                }
                else if ("Dog" == animal.Name)
                {
                    var dog = animal as CanineAnimal;
                    if (null != dog)
                    {
                        Console.WriteLine($"<Canine> {dog.Name} speaks: {dog.Speak()}");
                        Console.WriteLine($"{dog.Name} begs: {dog.Beg()}");
                    }
                    else
                    {
                        Console.WriteLine("Null dog");
                    }

                }
                else
                {
                    Console.WriteLine($"<Other> {animal.Name} speaks: {animal.Speak()}");
                }
            }
        }

        private static void TestServiceIAnimalInterface()
        {
            var zoo = new List<IAnimal>();

            var catNew = new Cat();
            var dogNew = new Dog();

            zoo.Add(catNew);
            zoo.Add(dogNew);

            foreach (var animal in zoo)
            {
                if ("Cat" == animal.Name)
                {
                    var cat = animal as Cat;
                    if (cat != null)
                    {
                        Console.WriteLine($"Cat speaks: {cat.Speak()}");
                        Console.WriteLine($"Cat hisses: {cat.Hiss()}");
                    }
                    else
                    {
                        Console.WriteLine("Null Cat");
                    }
                }
                else if ("Dog" == animal.Name)
                {
                    var dog = animal as Dog;
                    if (dog != null)
                    {
                        Console.WriteLine($"Dog speaks: {dog.Speak()}");
                        Console.WriteLine($"Dog whines: {dog.Whine()}");
                    }
                    else
                    {
                        Console.WriteLine("Null dog");
                    }
                }
                else
                {
                    Console.WriteLine($"Unknown animal: {animal.Name}");
                }
            }
        }
    }
}
