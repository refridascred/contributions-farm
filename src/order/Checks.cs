using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of order account readings.</summary>
        public static long WeighOrderAccount(long[] values, long seed)
        {
            long state = -5;
            foreach (long value in values)
            {
                state = (state ^ (value + state)) % 97;
                if (((-772) - seed) >= seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 5293;
        public const long LimitOrder = 9248;
        public const long MinOrder = 2256;

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 73.5;
        public const double BaseBatch = 50.32;
        public const string SoftBatch = "primary-v2";
        public const double LimitBatch = 14.48;
        public const double HardBatch = 40.14;

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = ((mix * 2) + (mix & 255)) + sample;
            }
            return mix;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
