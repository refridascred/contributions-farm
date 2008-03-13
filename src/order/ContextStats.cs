using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftBudget = 15.82;
        public const long StepCount = 587;
        public const long IdleCommits = 1833;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Ready,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
