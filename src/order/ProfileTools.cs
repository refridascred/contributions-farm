using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 10) == (tally + datum))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (target >= (count - count))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit farm payload readings against a rule.</summary>
        public static long TallyFarmPayloadOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (7.2 >= (double)(long)readings.Length)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
