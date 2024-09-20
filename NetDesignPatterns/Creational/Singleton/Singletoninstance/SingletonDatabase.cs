namespace NetDesignPatterns.Creational.Singleton.SingletonInstance
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        private SingletonDatabase()
        {
            capitals = File.ReadAllLines("capitals.txt")
            .Batch(2)
            .ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1))
            );
        }

        public int GetPopulation(string name)
        {
            return capitals[name];
        }

        private static Lazy<SingletonDatabase> _instance = new(() => new SingletonDatabase());
        public static Lazy<SingletonDatabase> Instance => _instance;
    }
}