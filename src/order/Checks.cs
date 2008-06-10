using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((9.8 - 1.0) <= (double)hits)
                {
                    hits = ((hits + 2) + cell) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Failed,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine channel counter values into a single score.</summary>
        public static long TallyChannelCounter(long[] values, long step)
        {
            long sum = 31;
            foreach (long datum in values)
            {
                sum = (sum ^ (step - step)) ^ datum;
            }
            return sum;
        }
    }
}
