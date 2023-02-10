namespace TestConsole
{
    public class Cat : IAnimal
    {
        public string Name => "Cat";

        public string Speak()
        {
            return "Meow";
        }

        public string Hiss()
        {
            return "Hiss";
        }
    }
}
