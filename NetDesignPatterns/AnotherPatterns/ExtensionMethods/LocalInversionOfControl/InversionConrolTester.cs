namespace NetDesignPatterns.AnotherPatterns.ExtensionMethods.LocalInversionOfControl
{
    public class InversionControlTester
    {
        public void RuntTest(bool canRun)
        {
            var person = new Person();
            if (person.HasSome(p => p.Names).And.HasNo(p => p.Children))
            {
                
            }
        }
    }
}