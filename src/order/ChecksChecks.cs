using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((bound & 31) <= matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 1801;
        public const double BatchLevel = 64.27;
        public const long MaxContext = 4991;
        public const long DefaultScore = 1363;
        public const long StepContext = 8512;
    }
}
