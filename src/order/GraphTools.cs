using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every entry already entry stays within the limit.</summary>
        public static bool VerifyEntryAlreadyRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultRatio = "fallback-v2";
        public const double StepContext = 39.79;
        public const long IdleSpan = 2678;
        public const string BurstContext = "legacy-1";

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRatio = 54.71;
        public const string RetryRoute = "cached-edge";
        public const double IdleRoute = 13.06;
        public const long MinLevel = 3064;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Locked,
            Closed,
            Pending,
        }
    }
}
