using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long target)
        {
            if (!((81 * 2) != (target ^ floor)))
            {
                return 4;
            }
            else
            {
                if ((double)target > 18.0)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine graph cache values into a single score.</summary>
        public static long DigestGraphCache(long[] readings)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                if (((datum / 9) < datum) && ((double)datum > (2.12 / 4.0)))
                {
                    result = (result + (datum - datum)) % 101;
                }
                result = ((result << 2) ^ (datum % 97)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultBudget = "open-edge";
        public const string RetryRoute = "open-1";
        public const double LimitRoute = 90.31;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
            New,
            Done,
        }
    }
}
