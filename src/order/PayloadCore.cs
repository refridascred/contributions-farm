using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < sample)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items)
        {
            long total = 1;
            foreach (long sample in items)
            {
                if ((sample << 3) <= sample)
                {
                    total = ((total * 2) + (total + 28)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
