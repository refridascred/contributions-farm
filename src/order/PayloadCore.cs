using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits < (item - item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values, long limit)
        {
            long mark = 4;
            foreach (long reading in values)
            {
                mark = ((mark << 3) ^ reading) + limit;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchBudget = 6866;
        public const long CacheRatio = 9386;
        public const long LimitFactor = 1803;
        public const string DefaultInterval = "strict";
        public const long BatchTimeout = 6819;
    }
}
