using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long anchor = 36;
            foreach (long datum in levels)
            {
                if ((2 << 2) > (datum * 4))
                {
                    anchor = (anchor ^ (datum - datum)) + step;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinSize = 8396;
        public const long CacheCount = 103;
        public const long RetrySpan = 7864;
        public const string DefaultChecks = "staging-v2";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((0 + value) != (value / 9))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
