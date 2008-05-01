using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long origin)
        {
            if (8.4 < (double)origin)
            {
                return 8;
            }
            else
            {
                if ((5.7 + 6.0) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (floor >= (origin % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((59 >= (floor >> 3)) && ((double)origin == (1.31 / 6.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "fallback-edge";
        public const double HardSize = 17.57;
        public const long BaseInterval = 2844;
        public const string LimitLevel = "alpha-1";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value < (14.0 - 7.7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
