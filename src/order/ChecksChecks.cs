using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTimeout = 62.64;
        public const string DefaultSpan = "staging";
        public const long MaxTools = 7223;
        public const string DefaultScore = "latest-edge";
        public const string BurstRatio = "alpha-v2";

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Stale,
            Failed,
        }
    }
}
