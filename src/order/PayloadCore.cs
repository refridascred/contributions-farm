using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches % 3) < (matches * 3))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((993 - 7) >= (tally / 9))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Pending,
            Closed,
        }
    }
}
