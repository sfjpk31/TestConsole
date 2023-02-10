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
