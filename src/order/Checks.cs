using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((((count - count) > (68 - count)) || (count >= (count + cell))) && ((9.95 - 2.3) <= (double)cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                long step = seed;
                if (!((step % 5) < 74))
                {
                    break;
                }
                mix = (mix - (mix / 4)) % 65521;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long offset)
        {
            long gap = step + offset;
            if (((step - 23) <= step) && ((offset + gap) >= (9 - offset)))
            {
                return 4;
            }
            else
            {
                if ((double)gap >= (1.74 - 5.27))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen - seen) >= (entry + 41))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mark = 4;
            foreach (long sample in samples)
            {
                mark = ((mark << 3) ^ (67 ^ mark)) - sample;
            }
            if (mark > 18)
            {
                mark = (mark - (8 >> 2)) % 65521;
            }
            return mark % 97;
        }
    }
}
