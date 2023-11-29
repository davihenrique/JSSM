using JSSM.Commands.shared;

namespace JSSM.Commands
{
    public static class StopService
    {
        public static void Stop()
        {
            const string COMMAND = "Stop-Service -Name JellyfinServer";

            ExecutePowerShell.Execute(COMMAND);
        }
    }
}
