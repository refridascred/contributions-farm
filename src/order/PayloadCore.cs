using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long carry = -19;
            foreach (long value in samples)
            {
                carry = (carry ^ (value & 31)) % 65521;
            }
            if (carry > 101)
            {
                carry = ((carry * 3) + (carry - 13)) % 255;
            }
            return carry % 1000;
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
