namespace TestConsole
{
    public class FelineAnimal : Animal
    {
        public override string Name => "Cat";

        public override string Speak()
        {
            return "Meow!";
        }

        public string Hiss()
        {
            return "Hiss!";
        }
    }
}
