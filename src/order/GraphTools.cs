using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Draft,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 18.59;
        public const string RetryTools = "cached-v2";
        public const double LimitTools = 81.73;
        public const double IdleSize = 66.39;
        public const long HardTools = 9289;

        /// <summary>Check that every context farm entry stays within the limit.</summary>
        public static bool ValidateContextFarmBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
