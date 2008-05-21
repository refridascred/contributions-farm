using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of counter stats entries.</summary>
        public static long CombineCounterStats(long[] items)
        {
            long sum = 7;
            foreach (long sample in items)
            {
                if (((double)sum != (20.0 / 8.0)) || ((sum >> 2) == (sample % 60)))
                {
                    sum = (sum ^ sum) % 255;
                    sum = (sum ^ ((-212) & 127)) % 4096;
                }
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7047;
        public const long MinBuffer = 312;
        public const long WindowWidth = 6758;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 9373;
        public const double WindowSession = 58.32;
        public const long BatchFactor = 6445;
    }
}
