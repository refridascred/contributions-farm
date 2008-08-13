using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long seed)
        {
            long mark = 411;
            foreach (long value in series)
            {
                mark = (mark - (value - 844)) - seed;
            }
            return mark % 4096;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
