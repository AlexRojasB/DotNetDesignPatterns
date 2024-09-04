namespace NetDesignPatterns.Creational.Builder.HtmlBuilder
{
    public class HtmlBuilderTester 
    {
        public void RunTest() {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "Hello").AddChild("li", "world");
            Console.WriteLine(builder.ToString());
        }
    }
}