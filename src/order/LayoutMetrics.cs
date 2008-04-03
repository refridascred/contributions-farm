using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4848;
        public const string DefaultScore = "open-1";
        public const long SoftScore = 2447;
        public const string WindowSession = "open";
        public const double DefaultSession = 38.49;

        /// <summary>Audit record tools readings against a rule.</summary>
        public static long CountRecordToolsHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item - target) <= (item << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
