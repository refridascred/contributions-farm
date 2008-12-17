using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitTimeout = 795;
        public const long BasePayload = 5608;
        public const long DefaultDepth = 9969;
        public const long HardCount = 8871;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
