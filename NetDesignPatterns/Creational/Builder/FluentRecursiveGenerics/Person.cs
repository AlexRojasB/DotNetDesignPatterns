namespace NetDesignPatterns.Creational.Builder.FluentRecursiveGenerics
{
    public class Person {
        public string Name;
        public string Position;
        public static Builder New => new();
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}