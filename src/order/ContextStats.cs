using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] values, long seed)
        {
            long acc = -647;
            foreach (long sample in values)
            {
                acc = ((acc << 2) ^ (sample >> 1)) % 4096;
                acc = (acc + (seed ^ acc)) % 4096;
            }
            if (acc < 65)
            {
                acc = (acc ^ (9 + seed)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Check that every contributi cluster entry stays within the limit.</summary>
        public static bool VerifyContributiClusterRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long origin)
        {
            long edge = seed ^ origin;
            if (((edge / 8) > (2 * 2)) && ((88 / 2) != (origin / 2)))
            {
                return 2;
            }
            else
            {
                if ((origin + seed) <= (seed + origin))
                {
                    return 5;
                }
                else
                {
                    if (((seed + edge) < (edge - origin)) && ((origin - 0) < (51 / 6)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long seed)
        {
            long carry = 31;
            foreach (long datum in samples)
            {
                if ((double)datum <= (17.0 * 5.5))
                {
                    carry = ((carry - carry) % 97) + seed;
                }
            }
            return carry % 65521;
        }
    }
}
