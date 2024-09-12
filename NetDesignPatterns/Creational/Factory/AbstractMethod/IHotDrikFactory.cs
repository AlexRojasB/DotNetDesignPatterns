namespace NetDesignPatterns.Creational.Factory.AbstractMethod
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}