using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Region { get; set; }
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 11.64;
        public const string LimitRatio = "standard-v2";
        public const double SoftScore = 30.0;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
