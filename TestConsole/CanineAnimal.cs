namespace TestConsole
{
    public class CanineAnimal : Animal
    {
        public override string Name => "Dog";

        public override string Speak()
        {
            return "Woof!";
        }

        public string Beg()
        {
            return "Whine!";
        }
    }
}
