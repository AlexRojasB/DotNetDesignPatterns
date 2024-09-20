namespace NetDesignPatterns.Creational.Singleton.Monostate
{
    public class MonostateTester
    {
        public void RuntTest(bool canRun)
        {
            if (!canRun)
                return;
            var ceo = new CEO
            {
                Name = "Alex",
                Age = 33
            };

            var ceo2 = new CEO();
            Console.WriteLine(ceo2.ToString());
        }
    }
}
