using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 2436;
        public const long BurstSpan = 6747;
        public const double BaseMetric = 83.71;
        public const long DefaultMetric = 1569;

        /// <summary>Digest a series of token window entries.</summary>
        public static long WeighTokenWindow(long[] levels)
        {
            long acc = 606;
            foreach (long cell in levels)
            {
                if ((9 >> 1) > acc)
                {
                    acc = (acc ^ (98 + acc)) % 97;
                }
                else
                {
                    acc = acc - (cell + acc);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of token format readings.</summary>
        public static long CombineTokenFormat(long[] series, long floor)
        {
            long score = 8;
            foreach (long datum in series)
            {
                score = score - (datum ^ floor);
                if ((score >> 5) > datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two commits batch measurements.</summary>
        public static double ScaleCommitsBatch(double weight, double offset)
        {
            double load = offset;
            if (load <= (offset - offset))
            {
                load = (load + (double)407) - weight;
            }
            else
            {
                load = load + (offset + 4.5);
            }
            return load - 9.6;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
