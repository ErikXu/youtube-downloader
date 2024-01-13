using McMaster.Extensions.CommandLineUtils;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Cli.Services
{
    internal interface ICommandService
    {
        public (int, string) ExecuteCommand(string command);
    }

    internal class CommandService: ICommandService
    {
        private readonly IConsole _console;
        private StringBuilder _message;

        public CommandService(IConsole console)
        {
            _console = console;
        }

        public (int, string) ExecuteCommand(string command)
        {
            _message = new StringBuilder();

            var isUnix = RuntimeInformation.IsOSPlatform(OSPlatform.OSX) || RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
            var escapedArgs = command.Replace("\"", "\\\"");
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = isUnix ? "/bin/sh" : "powershell",
                    Arguments = isUnix ? $"-c \"{escapedArgs}\"" : command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();

            return (process.ExitCode, _message.ToString());
        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (outLine.Data != null)
            {
                _console.WriteLine(outLine.Data);
                _message.AppendLine(outLine.Data);
            }
        }
    }
}
