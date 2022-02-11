using ConsoleApp1;
using System.Runtime.Loader;

Dictionary<string, IPlugin> Plugins = new Dictionary<string, IPlugin>();


const string pluginPath = @"C:\Users\ *My_user_name* \source\repos\Design-Patterns\Plugin-Architecture\Plugins";

Console.WriteLine("Start application");
LoadPlugins();

foreach (var key in Plugins.Keys)
{
    Plugins[key].DoProcess();
}

Console.WriteLine("End application");



void LoadPlugins()
{
    foreach (var dll in Directory.GetFiles(pluginPath, "*.dll"))
    {
        var assemblyLoadContext = new AssemblyLoadContext(dll);
        var assembly = assemblyLoadContext.LoadFromAssemblyPath(dll);

        IPlugin plugin = Activator.CreateInstance(assembly.GetTypes()[2]) as IPlugin;
        Plugins.Add(Path.GetFileNameWithoutExtension(dll), plugin);
    }

}
