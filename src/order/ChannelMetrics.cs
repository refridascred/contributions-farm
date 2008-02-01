using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Synced,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 5649;
        public const long WindowOrder = 1640;
        public const long BaseSize = 9747;

        /// <summary>Find the first schema order entry that matches the target.</summary>
        public static long LookupSchemaOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
