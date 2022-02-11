using ConsoleApp1;

namespace Plugin_Application1
{
    public class Plugin_A : IPlugin
    {
        public static readonly string Value = "This is Plugin_A"; 
        public void DoProcess()
        {
            Console.WriteLine(Value);
        }
    }
} 