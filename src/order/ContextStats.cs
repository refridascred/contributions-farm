using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 32.33;
        public const long MaxScore = 3040;
        public const long BurstContributi = 1582;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardDepth = 8941;
        public const string BurstBatches = "fallback-edge";
        public const long WindowBatches = 3428;
        public const long HardScore = 5182;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum ^ 967) > (hits >> 5)) && ((double)datum >= (17.0 - 13.0)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
