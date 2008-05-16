using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 7385;
        public const long RetryWidth = 4746;
        public const long BaseSize = 8883;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 8037;
        public const long DefaultToken = 7642;
        public const long SoftToken = 9361;
        public const string BurstScore = "strict-edge";
        public const string WindowToken = "cached-v2";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long SeriesQueueCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Pending,
            Failed,
            Dropped,
            Idle,
        }
    }
}
