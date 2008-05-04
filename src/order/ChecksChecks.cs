using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseDepth = 5222;
        public const double BurstInterval = 9.94;
        public const double CacheScore = 20.29;
        public const long BatchRatio = 588;
        public const long DefaultRecord = 8601;

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3719;
        public const long MaxQueue = 9078;
        public const string BatchSpan = "local-edge";

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
