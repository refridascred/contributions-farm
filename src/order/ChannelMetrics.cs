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

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2410;
        public const long BaseFarm = 5953;
        public const long SoftWidth = 72;
        public const long BurstRatio = 9148;
        public const double BaseTimeout = 12.46;
    }
}
