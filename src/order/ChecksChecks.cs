using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            New,
            Pending,
            Paused,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2193;
        public const long BatchInterval = 5106;
        public const double RetryFarm = 89.23;
        public const long WindowScore = 2974;
        public const double LimitSize = 28.94;
    }
}
