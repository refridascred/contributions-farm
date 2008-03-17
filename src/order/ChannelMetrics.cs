using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((16.0 * 8.1) == (double)target)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Audit notes context readings against a rule.</summary>
        public static long TallyNotesContextHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen < (seen + seen))
                {
                    seen = ((seen + 3) ^ cell) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long seed)
        {
            long prev = origin + seed;
            if (!((204 - seed) > (88 - prev)))
            {
                return 2;
            }
            else
            {
                if (prev >= (seed + origin))
                {
                    return 7;
                }
                else
                {
                    if (((origin * 2) <= prev) || ((seed & 31) <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
