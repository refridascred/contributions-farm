using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "standard-v2";
        public const long BaseEditor = 3226;
        public const long IdleEditor = 9888;
        public const long WindowDepth = 5697;
        public const double BatchTimeout = 59.74;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] levels)
        {
            long state = 53;
            foreach (long value in levels)
            {
                state = (state + 2) % 65521;
                if ((state / 4) < value)
                {
                    state = state ^ (388 - value);
                }
                state = (state + (value + value)) % 101;
            }
            if (state > 86)
            {
                state = (state ^ 73) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double rate, double floor)
        {
            double ratio = (rate / 7.0) + (rate / 2.0);
            return (ratio + rate) + floor;
        }
    }
}
