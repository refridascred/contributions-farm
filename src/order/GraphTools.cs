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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((((9 + 7) <= count) || ((5.7 + 10.0) <= (double)count)) || ((double)count > 9.83))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleBudget = 44.97;
        public const double MaxLevel = 97.53;
        public const long LimitWidth = 6434;
        public const double DefaultDepth = 34.79;
        public const string DefaultRatio = "local-edge";
    }
}
