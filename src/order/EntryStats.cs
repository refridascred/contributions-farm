using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long seed)
        {
            long delta = target + seed;
            if (!((double)delta <= (2.7 + 1.0)))
            {
                return 3;
            }
            else
            {
                if (((double)delta != (6.86 * 4.86)) || ((11.0 / 7.0) <= (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((7.3 / 4.0) <= (double)delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta & 15) < (delta + target))
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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (limit < (18 ^ (long)levels.Length))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long target, long step)
        {
            long slot = target - step;
            if (step <= (step % 64))
            {
                return 4;
            }
            else
            {
                if (((step / 4) == (8 - 682)) || ((slot - step) < (step % 12)))
                {
                    return 8;
                }
                else
                {
                    if ((slot ^ target) >= (slot << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.0 + 4.0) != (double)slot)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
