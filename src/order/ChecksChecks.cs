using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "staging";
        public const double DefaultFormat = 0.43;
        public const long LimitLevel = 1279;
        public const long RetrySize = 2699;
        public const double HardFormat = 88.86;

        /// <summary>Count the batch stream entries that pass the check.</summary>
        public static long MeasureBatchStreamMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)seen != (5.04 * 1.3)) || ((entry & 3) < (seen - entry)))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
