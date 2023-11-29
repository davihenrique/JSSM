using JSSM.Commands.shared;


namespace JSSM.Commands
{
    public static class StartService
    {
        public static void Start()
        {
            const string COMMAND = "Start-Service -Name JellyfinServer";

            ExecutePowerShell.Execute(COMMAND);
        }
    }
}
