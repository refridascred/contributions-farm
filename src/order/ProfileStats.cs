using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4902;
        public const long HardPayload = 1475;
        public const string BatchScore = "fallback-edge";
        public const long WindowLevel = 4041;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double RetryEntry = 30.94;
        public const string CacheScore = "local";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Ready,
            Dropped,
        }
    }
}
