using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits > (1.5 / 6.0))
                {
                    hits = ((hits + 3) + cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 56.19;
        public const long BatchDepth = 2293;
        public const string BatchRatio = "cached";

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Draft,
            Stale,
            Idle,
        }
    }
}
