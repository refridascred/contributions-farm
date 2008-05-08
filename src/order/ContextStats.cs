using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepWidth = 94.4;
        public const long MaxRatio = 8924;
        public const long CacheDepth = 547;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Done,
            Ready,
        }
    }
}
