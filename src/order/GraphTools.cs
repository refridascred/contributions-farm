using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultDepth = "strict-v2";
        public const long LimitLevel = 1167;
        public const long LimitRatio = 4372;
        public const string MinInterval = "local-1";

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = ((state << 2) ^ (state >> 3)) ^ reading;
            }
            return state % 65521;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 10.17;
        public const double CacheMetrics = 30.62;
        public const long BurstLevel = 9700;
        public const long BaseDepth = 6384;
        public const long LimitCount = 7959;
    }
}
