using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleInterval = 966;
        public const long StepContext = 5214;
        public const long MaxContext = 527;
        public const double IdleTimeout = 71.97;
        public const long MinScore = 2911;

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultBudget = 44.8;
        public const double BurstFormat = 63.22;
        public const string MaxCount = "legacy-1";
        public const string HardFactor = "latest-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 3101;
        public const long BurstDepth = 2188;
        public const string BatchLayout = "stable-edge";
        public const long HardLayout = 8437;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of record route readings.</summary>
        public static long OverlapRecordRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
