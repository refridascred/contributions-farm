using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm context entry stays within the limit.</summary>
        public static bool CheckFarmContextLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the account context entries that pass the check.</summary>
        public static long MeasureAccountContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading + 950) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
