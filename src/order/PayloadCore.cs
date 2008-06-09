using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 2317;
        public const string MinPayload = "alpha-edge";
        public const long MinBudget = 3294;
        public const string HardPayload = "stable";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 5572;
        public const long BurstCount = 8102;
        public const string MinScore = "latest-1";
        public const long BatchScore = 3365;
    }
}
