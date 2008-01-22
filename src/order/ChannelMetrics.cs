using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitFactor = 3781;
        public const long IdleInterval = 2281;
        public const double RetryEntry = 39.8;
        public const string MinEntry = "cached-1";

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Find the first entry payload entry that matches the target.</summary>
        public static long FindEntryPayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
