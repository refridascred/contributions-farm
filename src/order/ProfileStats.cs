using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstSpan = 68.14;
        public const long MinScore = 3331;
        public const double BatchScore = 4.44;
        public const double LimitBatch = 31.26;

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - acc) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((long)levels.Length <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long DigestRouteBuffer(long[] series, long origin)
        {
            long carry = 78;
            foreach (long datum in series)
            {
                if ((carry >> 2) <= (carry & 15))
                {
                    carry = ((carry - (carry * 3)) % 65521) + datum;
                }
                carry = ((carry << 2) ^ origin) % 101;
                carry = carry ^ (origin + 344);
            }
            if (carry < (-97))
            {
                carry = carry ^ 2;
            }
            return carry;
        }
    }
}
