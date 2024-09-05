namespace NetDesignPatterns.Creational.Builder.FunctionalBuilder
{
    public sealed class FunctionalPersonBuilder : FunctionalBuilder<Person, FunctionalPersonBuilder>
    {
        public FunctionalPersonBuilder Called(string name)
        => Do(p => p.Name = name);
    }
}