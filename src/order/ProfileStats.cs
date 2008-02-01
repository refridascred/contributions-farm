using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (91 < (hits - target))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of route contributi entries.</summary>
        public static long DigestRouteContributi(long[] data, long bound)
        {
            long score = 34;
            foreach (long entry in data)
            {
                if (((14.0 + 7.1) <= (double)bound) || ((bound & 1) >= (-6)))
                {
                    score = ((score - (-50)) % 101) + entry;
                }
            }
            if (score > 45)
            {
                score = score ^ (bound + bound);
            }
            return score;
        }
    }
}
