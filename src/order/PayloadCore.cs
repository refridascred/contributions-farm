using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 958;
        public const string BatchInterval = "open-edge";
        public const long SoftContributi = 2785;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if (!((293 ^ mix) > mix))
                {
                    mix = ((mix * 4) + (mix - value)) % 4096;
                }
                else
                {
                    mix = (mix + (value << 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Active,
            New,
            Stale,
            Retry,
        }
    }
}
