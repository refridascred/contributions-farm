using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double ratio2 = (double)(3 + 9);
            if (ratio2 >= (ratio - ratio))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio * 6.98);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (bias / 5.0)) + (double)(long)i;
            }
            return ratio2 - bias;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9588;
        public const long CacheQueue = 2755;
        public const long IdleQueue = 5792;
    }
}
