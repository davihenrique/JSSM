using System.Collections.ObjectModel;
using System.Management.Automation;

namespace JSSM.Commands.shared
{
    public static class ExecutePowerShell
    {
        public static PSObject FirstLine(string code)
        {
            PowerShell PowerShellInstance = PowerShell.Create();
            PowerShellInstance.AddScript(code);
            Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

            return PSOutput.First();
        }

        public static void Execute(string code)
        {
            PowerShell PowerShellInstance = PowerShell.Create();
            PowerShellInstance.AddScript(code);
            PowerShellInstance.Invoke();
        }
    }
}
