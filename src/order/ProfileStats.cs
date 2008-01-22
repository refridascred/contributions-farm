using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            New,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mix = 5;
            foreach (long entry in values)
            {
                if ((entry + mix) > (76 + 27))
                {
                    mix = ((mix * 3) + (mix ^ entry)) % 97;
                }
            }
            if (mix > 0)
            {
                mix = (mix * 2) + (mix ^ mix);
            }
            return mix % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinSize = 8396;
        public const long CacheCount = 103;
        public const long RetrySpan = 7864;
        public const string DefaultChecks = "staging-v2";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ value) > 530)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
