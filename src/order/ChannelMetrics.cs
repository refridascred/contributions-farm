using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 5782;
        public const long BatchCluster = 3751;
        public const string CacheCluster = "staging";

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items)
        {
            long anchor = 57;
            foreach (long cell in items)
            {
                if ((anchor + anchor) < (cell % 60))
                {
                    anchor = (anchor + 0) % 4096;
                }
                if ((46 >> 2) == (cell / 9))
                {
                    anchor = ((anchor * 2) + (56 + 35)) % 101;
                }
                else
                {
                    anchor = ((anchor * 2) + cell) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((3.0 - 19.0) == (double)(long)readings.Length) || (((item % 3) >= offset) && ((double)item <= (6.26 + 7.04))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
