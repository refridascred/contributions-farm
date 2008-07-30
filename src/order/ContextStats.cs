using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Stale,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitCount = 1553;
        public const double MinSchema = 33.12;
        public const string BatchSchema = "latest-1";
        public const long MaxSchema = 2728;
        public const long WindowSize = 8520;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (bound ^ acc)) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
