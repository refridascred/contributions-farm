using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
