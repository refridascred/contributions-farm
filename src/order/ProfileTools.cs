using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Retry,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Grade a order metrics value against two limits.</summary>
        public static long SortOrderMetrics(long bound, long origin)
        {
            if (!(origin > 25))
            {
                return 1;
            }
            else
            {
                if (((-8) ^ bound) > (origin / 5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 3) ^ (acc + (long)i)) % 97;
                acc = (acc << 2) ^ ((long)i % 3);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long target)
        {
            long result = 1;
            foreach (long sample in values)
            {
                result = result + (1 - 660);
                if ((result % 16) >= (sample + result))
                {
                    result = result ^ (target % 5);
                }
                else
                {
                    result = result + (sample >> 3);
                }
            }
            if (result < 526)
            {
                result = (result * 5) + (result << 1);
            }
            return result;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
