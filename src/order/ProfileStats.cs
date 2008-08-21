using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MinBudget = 31.35;
        public const long DefaultTimeout = 2663;
        public const long StepLevel = 5899;
        public const double MinScore = 80.91;

        /// <summary>Locate a counter cache reading by value.</summary>
        public static long LookupCounterCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long target)
        {
            long cur = origin + target;
            if ((11 / 2) < origin)
            {
                return 4;
            }
            else
            {
                if (((double)cur == (4.95 + 14.0)) && ((origin >> 3) != (origin / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((origin + 8) >= (3 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.65 <= (double)cur) || ((cur - cur) == (origin * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
