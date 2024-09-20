namespace NetDesignPatterns.Creational.Singleton.SingletonInstance
{
    public static class ExtesionMethods
{
    public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> source, int size)
    {
        List<T> batch = new List<T>(size);
        foreach (var item in source)
        {
            batch.Add(item);
            if (batch.Count == size)
            {
                yield return batch;
                batch = new List<T>(size);
            }
        }

        if (batch.Any())
        {
            yield return batch;
        }
    }
}

}