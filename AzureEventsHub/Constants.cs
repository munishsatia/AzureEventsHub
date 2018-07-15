using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.EventHubs;

namespace AzureEventsHub
{
    public static class Constants
    {
        
        public const string EhConnectionString = "Endpoint=sb://mdap-stream.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=DpJlva+SR50Zjf++MRZUF8w7m+BslO5/aLQq7cE1JjE=";
        public static string EhEntityPath = "mdap-stream-dps";


        public const string StorageContainerName = "gdccontainer";
        public const string StorageAccountName = "mdapstorage";
        public const string StorageAccountKey = "tEfKjNSu1fHB+VtX83fYXmcI34Bkm799IKXCDVt5M0+L+78u7sSMmgnn4wCwOYfTBnn19efUNFJzskqp6qSiDg==";

        public static readonly string StorageConnectionString = string.Format("DefaultEndpointsProtocol=https;AccountName={0};AccountKey={1}", StorageAccountName, StorageAccountKey);
    }
}
