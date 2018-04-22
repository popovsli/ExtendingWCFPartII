using System;
using WcfExtensions;

namespace ConsoleServices
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var serviceHost = new ExtendedServiceHost(typeof(FileService)))
                {
                    // Open the ServiceHost to start listening for messages.
                    serviceHost.Open();
                    // The service can now be accessed.
                    Console.WriteLine("The service is ready.");
                    Console.WriteLine("Press <ENTER> to terminate service.");
                    Console.ReadLine();

                    // Close the ServiceHost.
                    serviceHost.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(string.Format("Exception type: {0}", exception.GetType().AssemblyQualifiedName));
                Console.WriteLine(string.Format("Message: {0}", exception.Message));
                Console.WriteLine(string.Format("Stacktrace: {0}", exception.StackTrace));
                Console.ReadLine();
            }
        }
    }
}
