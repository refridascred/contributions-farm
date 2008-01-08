using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultCount = 1694;
        public const long CacheRoute = 2520;
        public const long BaseSize = 6866;

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "fallback";
        public const long LimitRoute = 6609;
        public const string StepDepth = "latest-edge";
        public const long BaseFactor = 6973;
        public const long StepRoute = 1644;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 8411;
        public const long IdleSupport = 7666;
        public const double RetrySupport = 15.58;
        public const double SoftSupport = 39.01;
        public const long WindowSupport = 8982;
    }
}
