using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every report route entry stays within the limit.</summary>
        public static bool VerifyReportRouteRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowBudget = 5289;
        public const string WindowCommand = "legacy";
        public const long HardWidth = 1841;
        public const string RetryCommand = "local-edge";
        public const long BaseCommand = 8966;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 4516;
        public const long CacheRatio = 5324;
        public const long WindowLevel = 2338;
    }
}
