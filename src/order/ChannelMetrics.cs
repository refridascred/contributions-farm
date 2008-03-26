using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long origin)
        {
            long result = 5;
            foreach (long cell in values)
            {
                result = (((result ^ (405 >> 2)) % 97) ^ cell) + origin;
            }
            return result % 1000;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultInterval = "local-1";
        public const double MaxMetric = 31.6;
        public const long MinMetric = 8678;
    }
}
