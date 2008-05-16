using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowDepth = "latest-v2";
        public const long DefaultLayout = 6599;
        public const string MaxSpan = "fallback-v2";
        public const long BatchTimeout = 776;
        public const long BatchDepth = 8689;

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
