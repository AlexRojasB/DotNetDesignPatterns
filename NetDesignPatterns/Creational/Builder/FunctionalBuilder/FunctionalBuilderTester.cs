namespace NetDesignPatterns.Creational.Builder.FunctionalBuilder
{
    public class FunctionalBuilderTester 
    {
        public  void RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            var person = new PersonBuilder()
            .Called("Sarah")
            .WorkAsA("Programmer")
            .Build();
            Console.WriteLine(person);
        }
    }
}