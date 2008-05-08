using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Done,
            Stale,
        }
    }
}
