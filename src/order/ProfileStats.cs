using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value ^ 0) < (value + value)) && ((4 / 5) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order route series from a seed.</summary>
        public static long StepOrderRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)953 == (double)bound)
                {
                    acc = (acc ^ (700 & 15)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
