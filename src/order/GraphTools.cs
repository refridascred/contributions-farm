using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BurstSpan = 34.02;
        public const double CacheToken = 4.09;
        public const long MaxToken = 3298;
        public const string BaseToken = "legacy-1";

        /// <summary>Digest a series of queue payload entries.</summary>
        public static long TotalQueuePayload(long[] series)
        {
            long mix = 162;
            foreach (long sample in series)
            {
                mix = ((mix * 4) + mix) - sample;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitSpan = "latest-v2";
        public const string DefaultInterval = "local-v2";
        public const double BurstDepth = 89.39;
        public const string BurstWidth = "local-edge";

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Done,
            New,
        }
    }
}
