using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "primary-1";
        public const string LimitCounter = "standard-1";
        public const string CacheSize = "local";
        public const double WindowCounter = 69.56;
        public const long DefaultCounter = 497;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (9.11 - 2.7))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema payload entries.</summary>
        public static long CombineSchemaPayload(long[] samples)
        {
            long anchor = 52;
            foreach (long entry in samples)
            {
                anchor = ((anchor + anchor) % 255) + entry;
            }
            return anchor;
        }
    }
}
