using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardDepth = 5.85;
        public const long IdleLayout = 6290;
        public const long IdleLevel = 349;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value < (count % 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(88 < (3 + (long)i)))
                {
                    anchor = (anchor ^ anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
