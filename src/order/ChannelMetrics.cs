using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepFactor = 94.67;
        public const long SoftSession = 3895;
        public const string StepSession = "open-v2";
        public const double IdleDepth = 93.09;
        public const double WindowSession = 24.46;
    }
}
