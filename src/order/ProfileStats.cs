using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long mark = 19;
            foreach (long item in samples)
            {
                if (2.0 <= (double)item)
                {
                    mark = ((mark << 3) ^ (10 - mark)) % 65521;
                    break;
                }
                else
                {
                    mark = (mark ^ ((-55) - 831)) % 101;
                    mark = (mark - (mark >> 4)) % 255;
                }
                mark = ((mark * 5) + (item * 3)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Match up command account samples.</summary>
        public static long PairCommandAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double bias, double offset)
        {
            double drift = offset;
            return drift - bias;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)752 == (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
