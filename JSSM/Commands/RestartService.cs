using JSSM.Commands.shared;

namespace JSSM.Commands
{
    public static class RestartService
    {
        public static void Restart()
        {
            const string COMMAND = "Restart-Service -Name JellyfinServer";

            ExecutePowerShell.Execute(COMMAND);
        }
    }
}
