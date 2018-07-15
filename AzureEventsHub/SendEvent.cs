using System;
using System.Text;
using System.Threading.Tasks;
using AzureEventsHub;
using Microsoft.Azure.EventHubs;

public class SendEvent
{
    public static EventHubClient eventHubClient;
    

    public static async Task SendAsync(string message)
    {
        var connection = new EventHubsConnectionStringBuilder(Constants.EhConnectionString)
        {
            EntityPath = Constants.EhEntityPath
        };
        eventHubClient = EventHubClient.CreateFromConnectionString(connection.ToString());
        //for (int i = 0; i < 10; i++)
        //{
        //    var msgBytes = Encoding.UTF8.GetBytes(message + i);
        //    await eventHubClient.SendAsync(new EventData(msgBytes));
        //}
        var input = "";
        do
        {
            Console.WriteLine("Enter message or q for quit \r\n");
            input = Console.ReadLine();
            var msgBytes = Encoding.UTF8.GetBytes(input);
            await eventHubClient.SendAsync(new EventData(msgBytes));
        } while (input != "q");
        

        await Task.Delay(5);
        await eventHubClient.CloseAsync();

    }

    //private static async Task SendMessageToEventHub(string message)
    //{
    //    var msgBytes = Encoding.UTF8.GetBytes(message);
    //    await eventHubClient.SendAsync(new EventData(msgBytes));

    //    await Task.Delay(5);
    //}
}
