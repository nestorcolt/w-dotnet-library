﻿namespace CloudLibrary.lib
{
    public static class Constants
    {
        // change this once I need to swap accounts. Can't get it dynamically because impacts performance ...
        public static readonly string AwsAccountId = "320132171574";

        // Settings for emulating the phone
        public static string AppVersion => "3.52.3.20.0";
        public static string OSVersion => "7.1.2";
        public static string DeviceModel => "SM-G977N";
        public static string BuildVersion => "N2G48C";

        // Sns Topics 
        public static readonly string AuthenticationSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-AUTHENTICATE-TOPIC";
        public static readonly string AcceptedSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-ACCEPTED-TOPIC";
        public static readonly string OffersSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-OFFERS-TOPIC";
        public static readonly string LogToCloudTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-LOGS-TOPIC";
        public static readonly string ErrorSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-ERROR-TOPIC";
        public static readonly string SleepSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-SLEEP-TOPIC";
        public static readonly string StopSnsTopic = $"arn:aws:sns:us-east-1:{AwsAccountId}:SE-STOP-TOPIC";

        // Sqs 
        public static readonly string UpdateOffersTableQueue = $"https://sqs.us-east-1.amazonaws.com/{AwsAccountId}/UpdateOffersTableQueue";
        public static readonly string UpdateBlocksTableQueue = $"https://sqs.us-east-1.amazonaws.com/{AwsAccountId}/UpdateBlocksTableQueue";

        // main URLS
        public const string AcceptInputUrl = "http://internal.amazon.com/coral/com.amazon.omwbuseyservice.offers/";
        public const string AuthTokenUrl = "https://api.amazon.com/auth/token";
        public const string ApiBaseUrl = "https://flex-capacity-na.amazon.com/";

        // paths
        public static string AcceptUri = "AcceptOffer";
        public static string OffersUri = "GetOffersForProviderPost";
        public static string ServiceAreaUri = "eligibleServiceAreas";

        public const string UserPk = "user_id";
        public static string UserLogStreamName = "User-{0}";
        public const string TokenKeyConstant = "x-amz-access-token";

        // Offers Table 
        public const int CleanUpOffersTimeThreshold = 48;
    }
}