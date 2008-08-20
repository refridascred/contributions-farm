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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum - sum) % 4096) - (long)i2;
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    sum = ((sum * 4) + (sum >> 5)) ^ (long)i3;
                }
                sum = sum - sum;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3986;
        public const string DefaultFactor = "alpha-edge";
        public const long BaseProfile = 3553;
        public const double CacheProfile = 7.36;
        public const long MaxDepth = 4667;

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
