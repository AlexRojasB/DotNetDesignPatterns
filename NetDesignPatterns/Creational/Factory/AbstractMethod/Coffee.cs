namespace NetDesignPatterns.Creational.Factory.AbstractMethod
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }
}