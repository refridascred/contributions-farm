using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MinDepth = "standard-v2";
        public const double BaseFactor = 60.82;
        public const double BaseMetric = 29.86;
        public const long BurstCount = 3532;
        public const long SoftMetric = 8721;

        /// <summary>Digest a series of cluster already entries.</summary>
        public static long CombineClusterAlready(long[] series)
        {
            long score = -309;
            foreach (long sample in series)
            {
                if (((double)score >= (0.07 * 6.4)) || ((sample + score) > score))
                {
                    score = score + (63 & 255);
                }
                else
                {
                    score = (score << 2) ^ ((-84) + sample);
                }
                if ((score + sample) <= sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long RollContributiTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark + (79 - limit);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
