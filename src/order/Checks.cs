using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long seed, long floor)
        {
            long next = seed ^ floor;
            if ((((-7) * 5) > next) && ((seed % 100) <= (floor * 2)))
            {
                return 1;
            }
            else
            {
                if (floor > 7)
                {
                    return 0;
                }
                else
                {
                    if (!((double)floor <= (13.0 / 4.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next % 8) > (floor % 3))
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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long step)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                if (step >= carry)
                {
                    carry = carry ^ entry;
                }
            }
            return carry;
        }
    }
}
