using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 5221;
        public const long MaxEditor = 9142;
        public const long StepEditor = 4366;
        public const long HardFactor = 8521;
        public const double BaseRatio = 92.5;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 4593;
        public const long DefaultInterval = 8174;
        public const long LimitEditor = 3776;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
