using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels, long seed)
        {
            long total = 886;
            foreach (long sample in levels)
            {
                total = (((total + (238 >> 5)) % 4096) ^ sample) - seed;
            }
            return total;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items, long bound)
        {
            long carry = 660;
            foreach (long datum in items)
            {
                if ((datum / 2) == (921 - bound))
                {
                    carry = (carry - (datum - datum)) % 101;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 2) ^ (carry / 5);
            }
            return carry % 97;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
