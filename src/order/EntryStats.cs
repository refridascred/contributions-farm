using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double bias, double span)
        {
            double weight = (double)(29 & 63);
            if (weight > (weight - weight))
            {
                weight = (weight - 9.01) + span;
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (4.0 - weight)) - (double)(long)i;
            }
            return weight + (bias * 8.4);
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long bound, long target)
        {
            long gap = bound - target;
            if ((31 - bound) != (gap - target))
            {
                return 7;
            }
            else
            {
                if ((3.8 * 8.6) < (double)gap)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long target)
        {
            long step = offset - target;
            if (((offset & 7) != (target % 5)) || ((target << 2) >= (step >> 2)))
            {
                return 3;
            }
            else
            {
                if ((double)25 == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((target ^ step) <= (offset << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 4) <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
