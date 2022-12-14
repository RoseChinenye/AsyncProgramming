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

            foreach (var p in runningProcesses)
            {
                string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
                Console.WriteLine(info);
            }
            Console.WriteLine("************\n");
        }

       
    }
}
