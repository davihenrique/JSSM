using JSSM.Commands.shared;
using System.Management.Automation;

namespace JSSM.Commands
{
    public static class GetStatusService
    {
        public static string StatusService
        {
            get
            {
                const string COMMAND = "Get-Service  JellyfinServer | Select-Object Status";

                PSObject output = ExecutePowerShell.FirstLine(COMMAND);

                if (output is null)
                    return "Error";

                string? statusService = output.Members["Status"].Value.ToString();

                return statusService ?? string.Empty;
            }
        }
    }
}
