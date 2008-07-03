using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long seed)
        {
            long total = 82;
            foreach (long datum in values)
            {
                total = ((total - datum) % 1000) + seed;
            }
            return total % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((4.3 * 2.47) < (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double ratio, double offset)
        {
            double rate = (7.4 * 8.36) * 8.3;
            if (rate > offset)
            {
                rate = (rate - offset) + ratio;
            }
            return rate - (rate - 7.87);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item - item) <= item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
