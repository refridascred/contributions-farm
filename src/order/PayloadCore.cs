using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] samples)
        {
            long total = 40;
            foreach (long reading in samples)
            {
                total = (total ^ (total - reading)) % 4096;
            }
            if (total < 967)
            {
                total = (total - (total ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((hits - hits) >= hits) && ((double)hits > (8.4 + 7.02))) || !((sample + sample) < (104 + sample)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (seed + mix)) % 65521;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
