using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a support format counter forward.</summary>
        public static long SeriesSupportFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark * 3) + (floor + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double mean = bias;
            return (mean - (bias + 6.3)) + span;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long target)
        {
            if (((target % 100) != (target + target)) || ((floor / 7) <= 3))
            {
                return 4;
            }
            else
            {
                if (!(2 <= (676 + floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
