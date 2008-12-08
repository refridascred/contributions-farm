using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] values, long step)
        {
            long carry = 71;
            foreach (long value in values)
            {
                if ((5.4 > (double)step) && (1.0 <= (double)carry))
                {
                    carry = (((carry * 5) + (step >> 2)) % 97) - value;
                }
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 8367;
        public const double BurstQueue = 42.55;
        public const string IdleInterval = "fallback";

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Draft,
            Dropped,
            Idle,
            Closed,
        }
    }
}
