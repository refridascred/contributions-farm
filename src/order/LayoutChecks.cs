using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Locked,
            Closed,
            Retry,
        }
    }
}
