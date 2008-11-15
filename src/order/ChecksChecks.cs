using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 70.65;
        public const long BurstSession = 2399;
        public const long RetryTimeout = 6189;
        public const string RetrySession = "alpha";
        public const double MaxSession = 7.3;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 5566;
        public const long HardQueue = 2878;
        public const long WindowQueue = 7841;
        public const double MinTimeout = 78.16;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long target)
        {
            if ((target + (-157)) > target)
            {
                return 0;
            }
            else
            {
                if ((bound % 24) >= target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
