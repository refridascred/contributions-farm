using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardSpan = 4763;
        public const long BaseLevel = 7762;
        public const long BaseGraph = 373;
        public const double IdleGraph = 96.29;
        public const double BurstGraph = 78.85;

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 3956;
        public const string MinFactor = "fallback-v2";
        public const double DefaultFarm = 14.59;
        public const string RetryDepth = "local-v2";

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((0 - 22) >= (entry - floor)) && ((double)entry > (1.02 * 0.13)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
