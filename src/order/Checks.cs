using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 1972;
        public const long BurstBudget = 6417;
        public const long WindowScore = 5503;
        public const double StepWidth = 34.66;
        public const string BurstSize = "fallback-1";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Draft,
            New,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseSpan = 5680;
        public const long BurstTimeout = 1468;
        public const long SoftRatio = 6278;
        public const long LimitInterval = 4930;

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long MeasurePayloadCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 2) > entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
