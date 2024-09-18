namespace NetDesignPatterns.AnotherPatterns.ExtensionMethods.LocalInversionOfControl
{
    public class Person
    {
        public IList<string> Names { get; set; }
        public IList<string> Children { get; set; }
    }
}