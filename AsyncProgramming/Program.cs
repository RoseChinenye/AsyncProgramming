using static AsyncProgramming.usingThread;
using static AsyncProgramming.processes;
using static AsyncProgramming.syncExample;


namespace AsyncProgramming;

public class Program
{
   public static async Task Main(string[] args)
    {
        Coffee cup = PourCoffee();
        Console.WriteLine("coffee is ready");

        Task<Egg> eggsTask = FryEggsAsync(2);
        Task<Bacon> baconTask = FryBaconAsync(3);
        Task<Toast> toastTask = ToastBreadAsync(2);

        Toast toast = await toastTask;
        ApplyButter(toast);
        ApplyJam(toast);
        Console.WriteLine("toast is ready");
        

        Egg eggs = await eggsTask;
        Console.WriteLine("eggs are ready");
        Bacon bacon = await baconTask;
        Console.WriteLine("bacon is ready");

        Console.WriteLine("Breakfast is ready!");
        Juice oj = PourOJ();
        Console.WriteLine("oj is ready");



        //ExtractExecutingThread();
        //EnumeratingProcesses();

        Console.ReadKey();
    }
}
