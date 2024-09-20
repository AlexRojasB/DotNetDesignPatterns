namespace NetDesignPatterns.Creational.Prototype.ExplicitDeepCopy
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}