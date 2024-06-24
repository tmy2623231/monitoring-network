using monitoring_for_Airport_network.controller;

namespace monitoring_for_Airport_network
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            directoryStructure directoryStructure = new directoryStructure();
            directoryStructure.CreateFile();
            ApplicationConfiguration.Initialize();
            Application.Run(new homeForm());
        }
    }
}