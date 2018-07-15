using System;
using AzureEventsHub.Receive;

namespace AzureEventsHub
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter Input - send or receive \r\n");
            var input = Console.ReadLine();
            Console.Write("User Entered : " + input + "\r\n");
            if (!String.IsNullOrEmpty(input) && input.ToLower().Equals("send"))
            {
                Console.Write("Sending \r\n");
                SendEvent.SendAsync("Message ").GetAwaiter().GetResult();
            }
            else
            {
                Console.Write("Receive \r\n");
                ReceiveEvent.ReceiveAsync().GetAwaiter().GetResult();
            }
            
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
