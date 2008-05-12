using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (bound >= (bound * 5))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long step, long offset)
        {
            long bound = step + offset;
            if ((double)offset < 3.26)
            {
                return 2;
            }
            else
            {
                if ((bound & 31) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((step / 4) >= (step / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            if ((double)bound2 > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((2.6 - 5.32) >= (double)bound2)
                {
                    return 1;
                }
                else
                {
                    if ((bound - bound) != (bound + 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((1 - 50) < bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell >= (1.0 / 6.0)))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
