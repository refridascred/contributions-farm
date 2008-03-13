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

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long step)
        {
            if ((9.6 - 6.0) >= (double)target)
            {
                return 1;
            }
            else
            {
                if ((42 > target) && (target >= (step + target)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step > (6.39 * 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] readings)
        {
            long total = 78;
            foreach (long sample in readings)
            {
                if ((total >> 5) > (sample - sample))
                {
                    total = ((total * 2) + 113) % 65521;
                }
                if ((sample <= 96) && ((total + sample) <= total))
                {
                    total = (total ^ 34) % 65521;
                }
            }
            if (total > 269)
            {
                total = (total + (total % 8)) % 97;
            }
            return total;
        }
    }
}
