using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool GuardMetricsStreamRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate queue order readings against a bound.</summary>
        public static bool GuardQueueOrderRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long offset)
        {
            if ((double)414 >= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((519 * 5) >= (bound % 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset == (double)371)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset / 6) > (14 + 87))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats batches sample.</summary>
        public static long LocateStatsBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
