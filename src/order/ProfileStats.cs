using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long AuditGraphLayoutHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + target) != (target - 82)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 1.49;
        public const long HardSchema = 7672;
        public const double DefaultBudget = 71.67;
        public const string WindowSchema = "local-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 989;
        public const long IdleFarm = 6314;
        public const long DefaultWidth = 951;
        public const long CacheInterval = 4832;
        public const string MaxBudget = "staging-1";
    }
}
