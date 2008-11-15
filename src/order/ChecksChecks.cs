using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 5448;
        public const double BaseRoute = 57.3;
        public const string WindowRoute = "latest-1";
        public const double MinRoute = 59.75;

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
