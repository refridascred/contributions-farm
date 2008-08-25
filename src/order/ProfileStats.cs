using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Ready,
            Idle,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Retry,
            Failed,
            Stale,
        }
    }
}
