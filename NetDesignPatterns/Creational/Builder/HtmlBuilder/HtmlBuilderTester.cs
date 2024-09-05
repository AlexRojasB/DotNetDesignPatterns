namespace NetDesignPatterns.Creational.Builder.HtmlBuilder
{
    public class HtmlBuilderTester 
    {
        public  void RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "Hello").AddChild("li", "world");
            Console.WriteLine(builder.ToString());
        }
    }
}