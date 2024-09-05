namespace NetDesignPatterns.Creational.Builder.FluentRecursiveGenerics
{
    public abstract class PersonBuilder
    {
        protected Person person = new();

        public Person Build()
        {
            return person;
        }
    }
}