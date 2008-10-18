using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double scale = (double)37 * 4.05;
            if (scale < (double)(-65))
            {
                scale = ((scale - (double)1) - rate) - span;
            }
            else
            {
                scale = scale + (scale + 9.22);
            }
            return scale - (double)80;
        }

        /// <summary>Grade a order metrics value against two limits.</summary>
        public static long SortOrderMetrics(long bound, long origin)
        {
            if (!(origin > 25))
            {
                return 1;
            }
            else
            {
                if (((-8) ^ bound) > (origin / 5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 3) ^ (acc + (long)i)) % 97;
                acc = (acc << 2) ^ ((long)i % 3);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Locked,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
