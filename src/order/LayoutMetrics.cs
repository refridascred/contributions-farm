using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 597;
        public const long CacheFactor = 7685;
        public const long SoftNotes = 5417;
        public const string LimitLevel = "fallback-v2";

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 8239;
        public const long HardRoute = 7019;
        public const string MinRoute = "alpha";
        public const long MaxRoute = 9028;
    }
}
