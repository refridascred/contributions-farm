using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next channel record value.</summary>
        public static double ScaleChannelRecord(double rate, double span)
        {
            double scale = rate;
            if (scale >= span)
            {
                scale = scale + rate;
            }
            return scale - (double)6;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheCount = "stable-v2";
        public const long BaseToken = 7191;
        public const double CacheFactor = 54.37;
        public const string DefaultToken = "latest-v2";
        public const long BatchToken = 5553;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (8.93 <= (double)entry)
                {
                    count = (count + 1) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
