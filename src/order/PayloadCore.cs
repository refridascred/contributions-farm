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

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
