using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account entry readings against a rule.</summary>
        public static long AuditAccountEntryMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (341 / 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long offset, long limit)
        {
            long cur = offset ^ limit;
            if (((limit - limit) >= (cur & 1)) || ((limit >> 3) >= (cur ^ limit)))
            {
                return 7;
            }
            else
            {
                if ((offset + limit) <= 999)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 8828;
        public const string CachePayload = "stable-edge";
        public const double BasePayload = 15.15;
        public const long BatchTimeout = 8269;
        public const long LimitPayload = 9752;
    }
}
