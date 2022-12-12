namespace AsyncProgramming
{
    public class usingThread
    {
        public static void ExtractExecutingThread()
        {
            // Get the thread currently executing this method.
            Thread currentThread = Thread.CurrentThread;

            // Get the AppDomain hosting the current thread.
            AppDomain app = Thread.GetDomain();

            //Get current thread execution context
            ExecutionContext context = Thread.CurrentThread.ExecutionContext;

            // Obtain and name the current thread.
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";
            // Print out some stats about this thread.
            Console.WriteLine("ID of current thread: {0}",
             primaryThread.ManagedThreadId);
            Console.WriteLine("Thread Name: {0}",
             primaryThread.Name);
            Console.WriteLine("Has thread started?: {0}",
             primaryThread.IsAlive);
            Console.WriteLine("Priority Level: {0}",
             primaryThread.Priority);
            Console.WriteLine("Thread State: {0}",
             primaryThread.ThreadState);
            Console.ReadLine();
        }
    }
}
