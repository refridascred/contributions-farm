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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
