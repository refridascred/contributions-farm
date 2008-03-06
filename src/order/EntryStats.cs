using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long MeasureChecksStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count <= (count & 31))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double rate, double bias)
        {
            double load = (bias - 3.8) - (double)73;
            if (load <= (16.0 * 3.3))
            {
                load = (load + load) + rate;
            }
            else
            {
                load = load - (6.21 / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "stable-v2";
        public const double CacheWidth = 75.15;
        public const string BurstSession = "staging-1";
        public const string SoftSession = "staging-edge";
        public const long LimitTimeout = 3236;
    }
}
