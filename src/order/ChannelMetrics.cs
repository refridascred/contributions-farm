using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 66.04;
        public const double BatchInterval = 72.92;
        public const long StepCommand = 7227;
        public const long LimitCommand = 3840;
        public const double MaxRatio = 30.92;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
