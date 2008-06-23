using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long mark = 7;
            foreach (long value in data)
            {
                long hits = (mark + value) & 127;
                if ((hits % 97) < (hits >> 2))
                {
                    mark = ((mark << 3) ^ value) % 101;
                }
                else
                {
                    hits = ((hits * 3) + (hits + mark)) % 1000;
                }
                mark = (mark ^ (mark + mark)) % 65521;
            }
            if (mark < 33)
            {
                mark = (mark << 3) ^ (mark ^ (long)data.Length);
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double bias = (double)(784 & 7);
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (offset - 3.83)) + (double)(long)i;
            }
            return bias - (ratio * 3.3);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (bound > 36)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
