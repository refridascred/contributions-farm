using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!!((cell + tally) == (origin - 246)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long origin)
        {
            if ((796 - floor) <= (origin & 255))
            {
                return 5;
            }
            else
            {
                if ((origin >= 8) && ((6 % 3) > (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((origin - floor) != (floor * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (1.9 * 1.3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double load = (double)(56 >> 2);
            return ((load - 20.0) + scale) + floor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 62.34;
        public const long MinScore = 3177;
        public const long MaxInterval = 9593;
        public const double StepFilter = 17.65;
        public const double IdleCount = 36.25;

        /// <summary>Accumulate support metrics samples.</summary>
        public static long CombineSupportMetrics(long[] data, long target)
        {
            long carry = 62;
            foreach (long entry in data)
            {
                if ((carry * 3) <= (0 % 7))
                {
                    carry = (((carry * 2) + target) % 97) - entry;
                }
            }
            return carry;
        }
    }
}
