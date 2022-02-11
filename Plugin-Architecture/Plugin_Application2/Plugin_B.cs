using ConsoleApp1;

namespace Plugin_Application2
{
    public class Plugin_B : IPlugin
    {
        public static readonly string Value = "This is Plugin_B";
        public void DoProcess()
        {
            Console.WriteLine(Value);
        }
    }
}