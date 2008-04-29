using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((double)tally == (3.0 - 2.0)) && (3.88 > (double)floor))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double offset)
        {
            double mean = offset;
            if (mean < (double)61)
            {
                mean = (mean + (double)12) - gain;
            }
            return mean + (double)40;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 2223;
        public const long HardInterval = 442;
        public const long RetryBatches = 3148;
        public const long WindowCount = 2178;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Mode { get; set; }
            public double Total { get; set; }
            public double Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
