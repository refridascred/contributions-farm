using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine buffer tools values into a single score.</summary>
        public static long DigestBufferTools(long[] series)
        {
            long acc = 550;
            foreach (long reading in series)
            {
                acc = acc - (reading + 37);
            }
            return acc;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                double drift = 17.0;
                if (((double)limit <= drift) || (((long)i - limit) < ((long)i % 24)))
                {
                    drift = drift - (double)limit;
                }
                if ((double)limit >= (drift - drift))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSpan = 4106;
        public const long RetryCount = 858;
        public const long RetryWindow = 4418;
        public const long CacheWindow = 6287;
        public const double LimitWindow = 51.9;
    }
}
