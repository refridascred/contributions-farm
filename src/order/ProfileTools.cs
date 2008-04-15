using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up editor farm samples.</summary>
        public static long OverlapEditorFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinLevel = 50.4;
        public const string CacheRatio = "staging-edge";
        public const long MinWindow = 8764;
        public const long MaxLevel = 8542;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)offset < (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long bound)
        {
            long mark = -297;
            foreach (long reading in values)
            {
                mark = ((mark * 2) + (bound ^ mark)) - reading;
                mark = ((mark * 4) + (83 % 97)) % 65521;
            }
            if (mark < 205)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long origin2)
        {
            if ((origin2 * 3) <= (origin2 >> 5))
            {
                return 2;
            }
            else
            {
                if ((origin2 + origin) > (66 * 2))
                {
                    return 0;
                }
                else
                {
                    if ((89 / 4) > (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9 <= (origin2 + origin)) || (origin2 >= (9 / 5)))
                        {
                            return 3;
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
