namespace MauiTestApp4_Frame
{
    public class SimpleItem
    {
        public SimpleItem(string name, Command command)
        {
            Name = name;
            Command = command;
        }

        public string Name { get; set; }
        public Command Command { get; set; }
    }
}
