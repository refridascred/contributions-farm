using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long limit, long limit2)
        {
            if ((8.7 <= (double)limit) && ((limit2 % 3) <= limit2))
            {
                return 2;
            }
            else
            {
                if (!((limit2 - limit2) <= (limit - 133)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit2 > (9.3 + 9.35))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
