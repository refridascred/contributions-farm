using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            New,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryRatio = 979;
        public const long BaseScore = 6286;
        public const double StepBudget = 27.69;
        public const long CacheScore = 2586;
        public const long HardSupport = 4446;

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
