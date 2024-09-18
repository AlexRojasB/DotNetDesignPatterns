namespace NetDesignPatterns.Creational.Factory.AbstractMethodOOP
{
    public class HotDrinkMachine
    {
        private List<Tuple<string, IHotDrinkFactory>> factories = [];

        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if(typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    factories.Add(Tuple.Create(t.Name.Replace("Factory", string.Empty), 
                    (IHotDrinkFactory) Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks:");
           for (int index = 0; index < factories.Count; index++)
           {
             var tuple = factories[index];
             Console.WriteLine($"{index}: {tuple.Item1}");
           }

           while (true)
           {
                string s;
                if((s = Console.ReadLine()) != null
                    && int.TryParse(s, out int i)
                    && i >= 0
                    && i <factories.Count)
                    {
                        Console.WriteLine("Specific amount: ");
                        s = Console.ReadLine();
                        if(s != null 
                            && int.TryParse(s, out int amount)
                            && amount > 0)
                            {
                                return factories[i].Item2.Prepare(amount);
                            }
                    } 
                Console.WriteLine("Incorrect input, try again!");
           }
        }
    }
}