using System.Diagnostics;

namespace AsyncProgramming
{
    internal class processes
    {
        public static void EnumeratingProcesses()
        {
            var runningProcesses = from proc in Process.GetProcesses()
                                   orderby proc.Id
                                   select proc;
            foreach (var proc in runningProcesses)
            {
                string info = $"-> PID: {proc.Id}\tName: {proc.ProcessName}";
                Console.WriteLine(info);
            }
            Console.WriteLine("************\n");
        }
    }
}
