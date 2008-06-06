using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark * 5) + 935) - (long)i;
                    mark = (mark << 3) ^ (mark + mark);
                }
                if ((7.66 - 8.54) != (double)mark)
                {
                    mark = ((mark * 5) + (40 * 4)) % 65521;
                }
                if ((datum + mark) > datum)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((9.0 + 7.94) >= (double)hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 964;
        public const long DefaultSize = 5152;
        public const double LimitRatio = 98.82;
        public const long MinScore = 5174;
        public const long RetryLevel = 9392;

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] samples, long seed)
        {
            long mix = -35;
            foreach (long cell in samples)
            {
                mix = (((mix * 3) + (cell + 60)) % 101) + seed;
            }
            return mix;
        }
    }
}
