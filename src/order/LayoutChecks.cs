using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetrySpan = "alpha-edge";
        public const string BurstBuffer = "legacy-v2";
        public const long BaseBuffer = 81;
        public const string DefaultBuffer = "primary-edge";

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
