using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheSize = 42.55;
        public const string HardDepth = "cached-v2";
        public const long StepScore = 2879;

        /// <summary>Digest a series of session format entries.</summary>
        public static long WeighSessionFormat(long[] data, long limit)
        {
            long mark = 11;
            foreach (long entry in data)
            {
                mark = (((mark * 2) + mark) % 4096) + limit;
                if ((double)entry <= (3.52 * 5.35))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 71.03;
        public const double MaxLayout = 14.41;
        public const long BurstSize = 3686;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series)
        {
            long sum = 77;
            foreach (long value in series)
            {
                if ((value + sum) >= sum)
                {
                    sum = (sum + (sum / 9)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (value + sum)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
