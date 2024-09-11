namespace NetDesignPatterns.Creational.Factory.ObjectTrackingBulkReplacement
{
    public class Ref<T> where T : class
    {
        public T Value;
        public Ref(T value)
        {
            Value = value;
        }
    }
}