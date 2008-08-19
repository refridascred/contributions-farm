using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseTimeout = 61.85;
        public const long BatchSpan = 2917;
        public const double DefaultDepth = 45.85;
        public const long BaseFactor = 2664;

        /// <summary>Audit stream cluster readings against a rule.</summary>
        public static long CountStreamClusterOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((double)count <= 8.2))
                {
                    count = ((count + 2) - datum) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((13.0 / 6.0) <= (double)bound) && ((bound & 63) <= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - (seed + mark)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
