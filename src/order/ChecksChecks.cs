using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseWidth = 57.01;
        public const double BatchDepth = 18.06;
        public const long HardCache = 8686;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((-2) * 2) >= (sample << 2))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Locked,
            Done,
            Closed,
            Retry,
        }
    }
}
