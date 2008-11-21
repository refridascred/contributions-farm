using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long target)
        {
            long edge = bound + target;
            if ((8.92 - 1.6) < (double)edge)
            {
                return 6;
            }
            else
            {
                if (edge <= target)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

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
