using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace CMDCs.Bridge
{
    public class Response
    {
        public int code { get; set; }
        public string stdout { get; set; }
        public string stderr { get; set; }
    }

    public enum Output
    {
        Hidden,
        Internal,
        External
    }

    public static class Shell
    {
        private static string GetFileName()
        {
            return "cmd.exe";
        }


        private static string CommandConstructor(string cmd, Output? output = Output.Hidden, string dir = "")
        {

            if (!String.IsNullOrEmpty(dir))
            {
                dir = $" \"{dir}\"";
            }
            if (output == Output.External)
            {
                cmd = $"{Directory.GetCurrentDirectory()}/cmd.win.bat \"{cmd}\"{dir}";
            }
            cmd = $"/c \"{cmd}\"";
 
            return cmd;
        }

        public static Response Term(string cmd, Output? output = Output.Hidden, string dir = "")
        {
            var result = new Response();
            var stderr = new StringBuilder();
            var stdout = new StringBuilder();

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = GetFileName();
                startInfo.Arguments = CommandConstructor(cmd, output, dir);
                startInfo.RedirectStandardOutput = !(output == Output.External);
                startInfo.RedirectStandardError = !(output == Output.External);
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = !(output == Output.External);
                if (!String.IsNullOrEmpty(dir) && output != Output.External)
                {
                    startInfo.WorkingDirectory = dir;
                }

                using (Process process = Process.Start(startInfo))
                {
                    stdout.AppendLine(process.StandardOutput.ReadToEnd());
                    stderr.AppendLine(process.StandardError.ReadToEnd());


                    process.WaitForExit();
                    result.stdout = stdout.ToString();
                    result.stderr = stderr.ToString();
                    result.code = process.ExitCode;
                }

            return result;
        }
    }
}

namespace CMDCs
{
    public static class CMD
    {
        public static string Command(string command)
        {
            CMDCs.Bridge.Response result = CMDCs.Bridge.Shell.Term(command, CMDCs.Bridge.Output.Hidden);


            if (result.code == 0)
            {
                return result.stdout.ToString();
            }
            else
            {
                if (result.stderr.Length < 5)
                    return result.stdout.ToString();
                return result.stderr;
            }
        }
    }
}
