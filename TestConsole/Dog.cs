namespace TestConsole
{
    public class Dog : IAnimal
    {
        public string Name => "Dog";

        public string Speak()
        {
            return "Woof";
        }

        public string Whine()
        {
            return "Whine";
        }
    }
}
