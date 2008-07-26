using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardWidth = "local-1";
        public const double HardDepth = 56.88;
        public const string BurstSize = "local-v2";

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long floor)
        {
            if ((double)origin != (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)9 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
