namespace NetDesignPatterns.Creational.Builder.FunctionalBuilder
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorkAsA(this PersonBuilder builder, string position)
         => builder.Do(p => p.Position = position);

        public static FunctionalPersonBuilder WorkAsA(this FunctionalPersonBuilder builder, string position)
        => builder.Do(p => p.Position = position);
    }
}