using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepScore = 7818;
        public const long CacheRatio = 385;
        public const double WindowBudget = 57.51;

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySpan = 2993;
        public const long HardFarm = 1929;
        public const long CacheFarm = 9815;
        public const string MaxFarm = "primary-edge";
        public const double DefaultLevel = 66.42;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 4) >= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 3407;
        public const long StepLevel = 3972;
        public const double BatchSpan = 80.11;
        public const long StepTimeout = 3148;

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((17 / 7) <= seed)
            {
                return 5;
            }
            else
            {
                if ((floor << 3) >= (bound / 4))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Synced,
            Idle,
        }
    }
}
