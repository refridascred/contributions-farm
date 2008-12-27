using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowFactor = 97.07;
        public const long BatchProfile = 2231;
        public const long BaseProfile = 8068;
        public const long CacheSpan = 6153;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (acc ^ (acc << 2)) - (long)i2;
                    acc = ((acc * 5) + 1) % 255;
                }
                if (!(((acc & 63) == (acc % 60)) || ((limit ^ limit) > acc)))
                {
                    acc = ((acc << 2) ^ limit) % 97;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
