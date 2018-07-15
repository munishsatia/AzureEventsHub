using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.EventHubs;
using Microsoft.Azure.EventHubs.Processor;

namespace AzureEventsHub.Receive
{
    public static class ReceiveEvent
    {
        public static async Task ReceiveAsync()
        {
            Console.WriteLine("Receive Started...");
            var eventProcessorHost = new EventProcessorHost(
                Constants.EhEntityPath,
                PartitionReceiver.DefaultConsumerGroupName,
                Constants.EhConnectionString,
                Constants.StorageConnectionString,
                Constants.StorageContainerName);

            await eventProcessorHost.RegisterEventProcessorAsync<EventProcessor>();
            Console.WriteLine("Receiving. Press ENTER to stop worker.");
            Console.ReadLine();
            await eventProcessorHost.UnregisterEventProcessorAsync();
        }

    }
}
