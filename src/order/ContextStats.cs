using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits << 2) < ((-484) / 5))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long step)
        {
            long slot = floor - step;
            if (step > (1 + step))
            {
                return 2;
            }
            else
            {
                if ((44 + slot) <= floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)step <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (slot > floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = (result + ((long)i + (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
