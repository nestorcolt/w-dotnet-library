namespace CloudLibrary.Common
{
    public static class Constants
    {
        // change this once I need to swap accounts. Can't get it dynamically because impacts performance ...
        public static readonly string AwsAccountId = "320132171574";

        // SNS 
        public static readonly string AuthenticationSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-AUTHENTICATE-TOPIC";
        public static readonly string AcceptedSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-ACCEPTED-TOPIC";
        public static readonly string OffersSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-OFFERS-TOPIC";
        public static readonly string LogToCloudTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-LOGS-TOPIC";
        public static readonly string ErrorSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-ERROR-TOPIC";
        public static readonly string SleepSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-SLEEP-TOPIC";
        public static readonly string StopSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-STOP-TOPIC";

        // SQS 
        public static readonly string UpdateOffersTableQueue = $"https://sqs.us-east-1.amazonaws.com/{AwsAccountId}/UpdateOffersTableQueue";
        public static readonly string UpdateBlocksTableQueue = $"https://sqs.us-east-1.amazonaws.com/{AwsAccountId}/UpdateBlocksTableQueue";

        public const string UserPk = "user_id";
        public static string UserLogStreamName = "User-{0}";

    }
}