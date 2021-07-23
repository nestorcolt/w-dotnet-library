using System;
using System.Threading.Tasks;
using CloudLibrary.Common;

namespace CloudLibrary.Core
{
    public static class LogsHandler
    {
        public static async Task Log(string message, string userId)
        {
            await SnsHandler.PublishToSnsAsync(message, String.Format(Constants.UserLogStreamName, userId), Constants.LogToCloudTopic);
        }
    }
}