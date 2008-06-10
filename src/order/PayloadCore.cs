using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 9151;
        public const long BurstRecord = 9706;
        public const long BaseDepth = 1969;
        public const long BatchCount = 1155;
        public const long BatchLevel = 931;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Dropped,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Count the context editor entries that pass the check.</summary>
        public static long MeasureContextEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "open-v2";
        public const long CacheBudget = 4214;
        public const long CacheTimeout = 9160;
        public const long SoftTimeout = 7976;
        public const double IdleCounter = 24.19;
    }
}
