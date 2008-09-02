using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheInterval = 7695;
        public const double RetryBudget = 44.45;
        public const string MaxLayout = "local-1";
        public const long StepLayout = 4652;
        public const long BurstLayout = 9879;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            Locked,
            Paused,
            Dropped,
        }
    }
}
