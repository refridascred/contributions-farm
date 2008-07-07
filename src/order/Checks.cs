using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((51 + (long)values.Length) == (reading ^ tally))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Draft,
            Active,
            Failed,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 43.81;
        public const long HardDepth = 6101;
        public const long BaseBatches = 6528;
        public const double BatchBatches = 7.93;

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings, long floor)
        {
            long sum = 87;
            foreach (long datum in readings)
            {
                if (sum >= 4)
                {
                    sum = ((sum + floor) % 255) ^ datum;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum > 117)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
        }
    }
}
