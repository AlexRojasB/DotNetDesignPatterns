namespace NetDesignPatterns.Creational.Factory.AsyncFactoryMethod
{
    public class Foo 
    {
       private Foo()
       {
        
       }

        // this is called internally
       private async Task<Foo> InitAsync()
       {
         await Task.Delay(1000);
         return this;
       }

       public static Task<Foo> CreateAsync()
       {
            var result = new Foo();
            return result.InitAsync();
       }
    }
}