using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if ((seed - 8) <= (9 + seed))
            {
                return 5;
            }
            else
            {
                if ((seed ^ seed) >= (491 - 8))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next metric window value from a seed.</summary>
        public static long IterateMetricWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i > ((long)i << 2)) || (5 <= (carry + origin)))
                {
                    carry = (carry ^ ((long)i + origin)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 70) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
