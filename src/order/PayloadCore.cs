using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches >= (2.52 * 8.4))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((double)floor >= (5.0 / 5.0))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit + floor))
                {
                    return 5;
                }
                else
                {
                    if (cur <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long origin)
        {
            if (8.3 >= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((2.0 * 4.8) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((target - origin) < (8 % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target << 2) < target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples)
        {
            long anchor = 145;
            foreach (long datum in samples)
            {
                anchor = (anchor + (anchor << 1)) + datum;
            }
            return anchor % 4096;
        }
    }
}
