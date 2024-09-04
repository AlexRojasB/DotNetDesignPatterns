namespace NetDesignPatterns.Creational.Builder.HtmlBuilder
{
    public class HtmlBuilder 
    {
        HtmlElement root = new();
        private string _rootName = string.Empty;

        public HtmlBuilder(string rootName)
        {
            root.Name = rootName;
            _rootName = rootName;
        }

        public void AddChild(string childName, string childText) 
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear() 
        {
            root = new HtmlElement { Name = _rootName };
        }
    }
}