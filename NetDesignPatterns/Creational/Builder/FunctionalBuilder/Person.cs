namespace NetDesignPatterns.Creational.Builder.FunctionalBuilder
{
    public class Person 
    {
     public string Name;
        public string Position;
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}