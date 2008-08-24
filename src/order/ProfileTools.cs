using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples, long limit)
        {
            long total = 946;
            foreach (long value in samples)
            {
                total = (total << 3) ^ (value + value);
                total = (total * 3) + (value - total);
                total = (total * 3) + (total + total);
                if (((total - value) >= (total - 1)) && ((8.5 * 1.5) > (double)limit))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Classify a contributi route pair into a bucket.</summary>
        public static long SortContributiRoute(long limit, long bound)
        {
            long gap = limit ^ bound;
            if (!((6 << 1) <= (gap ^ gap)))
            {
                return 2;
            }
            else
            {
                if ((bound + limit) < (gap >> 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long target)
        {
            if ((target + offset) >= (34 / 2))
            {
                return 4;
            }
            else
            {
                if ((offset ^ 776) >= (target ^ offset))
                {
                    return 5;
                }
                else
                {
                    if (70 < (target >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series, long bound)
        {
            long mix = 661;
            foreach (long item in series)
            {
                mix = (mix - (item / 2)) % 101;
                if (mix > (bound - 67))
                {
                    mix = (mix - (bound & 3)) % 4096;
                }
            }
            if (mix < 5)
            {
                mix = (mix - (mix + bound)) % 101;
            }
            return mix;
        }
    }
}
