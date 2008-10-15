using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchSpan = 135;
        public const long MaxRoute = 5271;
        public const double StepSpan = 14.71;
        public const long IdleFactor = 8064;
        public const string HardRoute = "stable-edge";

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Stale,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((double)68 >= (double)bound) || ((double)seen <= 16.0)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
