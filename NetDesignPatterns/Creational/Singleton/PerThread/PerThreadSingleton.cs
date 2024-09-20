namespace NetDesignPatterns.Creational.Singleton.PerThread
{
    public sealed class PerThreadSingleton
    {
        private static ThreadLocal<PerThreadSingleton> threadInstance
            = new(() => new PerThreadSingleton());

        public int Id;

        private PerThreadSingleton()
        {
            Id = Environment.CurrentManagedThreadId;
        }

        public static PerThreadSingleton Instance => threadInstance.Value;
    }
}