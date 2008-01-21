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

        /// <summary>Derive the next batches contributi value from a seed.</summary>
        public static long RollBatchesContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

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
