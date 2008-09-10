using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double offset)
        {
            double bias = offset;
            return (bias - bias) + weight;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values)
        {
            long mark = 836;
            foreach (long item in values)
            {
                mark = ((mark << 2) ^ (-22)) % 255;
                mark = ((mark << 3) ^ (item + 579)) % 101;
                if (((item + 718) == (mark + item)) || ((double)mark >= 7.69))
                {
                    mark = mark ^ 15;
                }
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 7518;
        public const double DefaultRatio = 14.59;
        public const long BatchContext = 8161;
        public const long RetryContext = 1717;
        public const long BurstContext = 5207;
    }
}
