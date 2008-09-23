using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (double)(-258))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long seed)
        {
            long mark = 52;
            foreach (long reading in values)
            {
                if (!((seed & 15) <= seed))
                {
                    mark = ((mark * 5) + reading) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 2048;
        public const string BaseStream = "primary-1";
        public const double LimitInterval = 41.55;
    }
}
