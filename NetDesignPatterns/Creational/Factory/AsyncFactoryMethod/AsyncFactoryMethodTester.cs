namespace NetDesignPatterns.Creational.Factory.AsyncFactoryMethod
{
    public class AsyncFactoryMethodTester 
    {
        public  async Task RunTest(bool canRun = false) {
            if(!canRun)
            {
                return;
            }
            Foo x = await Foo.CreateAsync(); // This is how you initialize the object
        }
    }
}