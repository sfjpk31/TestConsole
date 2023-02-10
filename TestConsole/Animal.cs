namespace TestConsole
{
    public class Animal
    {
        public virtual string Name => "Animal";

        public virtual string Speak()
        {
            return "<silence>";
        }
    }
}
