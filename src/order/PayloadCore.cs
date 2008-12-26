using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long seed)
        {
            if ((14.0 + 3.69) < (double)origin)
            {
                return 7;
            }
            else
            {
                if (((seed * 4) == (origin - origin)) && ((3.28 + 0.6) >= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (7 <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((double)entry < (2.0 * 5.6)) || (1.5 > (double)seen)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry context entries.</summary>
        public static long DigestEntryContext(long[] series, long limit)
        {
            long result = 388;
            foreach (long datum in series)
            {
                if (((datum % 3) < (limit ^ datum)) && ((double)datum <= (1.0 + 9.28)))
                {
                    result = result ^ (97 - datum);
                }
            }
            return result % 4096;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
