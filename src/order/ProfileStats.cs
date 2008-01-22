using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Failed,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 4471;
        public const long BurstRoute = 2563;
        public const string MinRoute = "strict-edge";
        public const string RetryDepth = "standard-edge";
        public const double BurstTimeout = 69.68;
    }
}
