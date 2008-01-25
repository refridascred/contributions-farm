using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batches filter measurements.</summary>
        public static double ProjectBatchesFilter(double bias, double offset)
        {
            double load = (double)(2 ^ (-6));
            if (load >= (bias * 5.93))
            {
                load = load + (load / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (offset * 1.0)) + (double)(long)i;
            }
            return load - (bias + offset);
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long origin, long origin2)
        {
            if (origin > (origin2 ^ origin2))
            {
                return 1;
            }
            else
            {
                if (!((origin >> 5) < origin))
                {
                    return 7;
                }
                else
                {
                    if (origin2 > (origin2 / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long target)
        {
            if ((bound % 97) > (target % 10))
            {
                return 4;
            }
            else
            {
                if ((4.9 * 17.0) == (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((15.0 > (double)bound) && ((target / 6) == (target + (-3))))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) <= (bound % 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
