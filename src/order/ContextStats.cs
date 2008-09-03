using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the graph checks series from a seed.</summary>
        public static long RollGraphChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry ^ (limit & 7)) + (long)i2;
                    carry = (carry + (limit + limit)) % 4096;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    carry = ((carry - (limit + carry)) % 4096) - (long)i3;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long limit, long bound)
        {
            long lane = limit ^ bound;
            if ((bound % 10) <= lane)
            {
                return 0;
            }
            else
            {
                if ((double)limit < (1.4 * 1.4))
                {
                    return 3;
                }
                else
                {
                    if ((bound << 3) > (limit + lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 54.96;
        public const string WindowContext = "stable";
        public const double BatchRatio = 63.79;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
