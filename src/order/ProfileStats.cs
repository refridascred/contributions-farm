using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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

        /// <summary>Accumulate layout buffer samples.</summary>
        public static long FoldLayoutBuffer(long[] levels)
        {
            long total = 3;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ total) % 1000;
                if (((entry - total) == (total ^ 9)) || (total <= (total << 3)))
                {
                    break;
                }
            }
            return total;
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
