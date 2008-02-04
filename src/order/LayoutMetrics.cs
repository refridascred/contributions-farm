using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long seed, long origin)
        {
            if ((seed >= (seed + origin)) || (seed > origin))
            {
                return 5;
            }
            else
            {
                if ((seed % 100) >= (27 - origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchSpan = 8.08;
        public const long RetryDepth = 8435;
        public const long DefaultWidth = 6003;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
