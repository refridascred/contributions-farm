using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4558;
        public const double LimitChecks = 37.29;
        public const long IdleRatio = 9445;
        public const long BaseCount = 9617;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 8274;
        public const string MinLevel = "local-edge";
        public const double BatchRoute = 82.0;

        /// <summary>Validate support token readings against a bound.</summary>
        public static bool GuardSupportTokenLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Done,
            Synced,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4643;
        public const double IdleCount = 84.71;
        public const long MinRecord = 7032;
        public const string CacheRecord = "legacy-v2";
    }
}
