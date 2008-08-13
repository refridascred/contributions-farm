using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFactor = 1846;
        public const string LimitWidth = "fallback-v2";
        public const long SoftFilter = 7073;
        public const long StepBudget = 7192;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const string StepSize = "staging-v2";
        public const long LimitBudget = 1419;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
