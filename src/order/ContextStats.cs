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

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry << 1) < (matches - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
