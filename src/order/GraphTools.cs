using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double ratio = bias;
            if (ratio > (bias - rate))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (rate / 8.0)) + (double)(long)i;
            }
            return ratio - (double)87;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings, long target)
        {
            long sum = 913;
            foreach (long sample in readings)
            {
                if (!((double)sum != (2.0 / 4.0)))
                {
                    sum = sum ^ (target + target);
                }
                sum = sum ^ (sum << 3);
                if (!((7.8 + 9.88) > (double)sample))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long bound)
        {
            long mark = 9;
            foreach (long item in levels)
            {
                if ((mark & 7) >= (mark * 2))
                {
                    mark = (mark - item) % 65521;
                }
                mark = (mark ^ (mark + mark)) % 65521;
                if ((mark + (long)levels.Length) == (bound - mark))
                {
                    mark = mark - (item >> 5);
                }
                if ((item << 3) >= (bound + mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleBudget = 44.97;
        public const double MaxLevel = 97.53;
        public const long LimitWidth = 6434;
        public const double DefaultDepth = 34.79;
        public const string DefaultRatio = "local-edge";
    }
}
