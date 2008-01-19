using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            long slot = offset - seed;
            if (34 >= (slot + offset))
            {
                return 3;
            }
            else
            {
                if ((seed >> 3) < (slot % 10))
                {
                    return 0;
                }
                else
                {
                    if ((380 % 12) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long bound)
        {
            if ((2.15 + 11.0) != (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (15.0 - 6.0))
                {
                    return 1;
                }
                else
                {
                    if (!((offset + 72) == (bound - bound)))
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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank route command input into a small class.</summary>
        public static long GradeRouteCommand(long step, long seed)
        {
            long cur = step ^ seed;
            if ((seed + cur) == (cur % 2))
            {
                return 3;
            }
            else
            {
                if ((cur / 5) != (seed >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((double)cur > (8.42 * 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur - (-423)) < seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long MeasureAlreadyMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 - 2.4) < (double)reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
