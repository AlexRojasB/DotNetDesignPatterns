namespace NetDesignPatterns.Creational.Builder.FacetedBuilder
{
    public class FacetedBuilderTester
    {
        public void RunTest(bool canRun = false)
        {
            if (!canRun)
            {
                return;
            }
            var pb = new PersonBuilder();
            
            Person person = pb
                .Works.At("Gorilla Logic")
                      .AsA("Backend Developer")
                      .Earning(120000)
                .Lives.At("Costa Rica")
                      .In("Garabito")
                      .WithPostCode("72001");

            Console.WriteLine(person);
        }
    }
}