using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepCount = 9240;
        public const long StepSize = 2044;
        public const string IdleNotes = "strict-v2";
        public const string HardDepth = "alpha";

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((-364) - 28) >= value)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long floor, long target)
        {
            long next = floor - target;
            if ((14 * 3) != (805 - target))
            {
                return 1;
            }
            else
            {
                if (!((double)floor == (3.6 + 4.1)))
                {
                    return 8;
                }
                else
                {
                    if ((5.27 > (double)next) && ((target >> 3) <= (target + next)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (next <= target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
