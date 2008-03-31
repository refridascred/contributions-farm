using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 67.1;
        public const string BaseScore = "stable-1";
        public const double WindowCount = 30.3;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long target)
        {
            long bound2 = bound - target;
            if ((bound2 >> 2) == (target + bound))
            {
                return 4;
            }
            else
            {
                if ((228 < (1 ^ bound)) || ((89 - target) < (bound & 15)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a farm support reading.</summary>
        public static double ProjectFarmSupport(double ratio, double floor)
        {
            double ratio2 = floor / 7.0;
            if (ratio2 < (ratio2 * 0.02))
            {
                ratio2 = (ratio2 + (double)9) - ratio;
            }
            else
            {
                ratio2 = ratio2 + (double)574;
            }
            return ratio2 - (floor + floor);
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
