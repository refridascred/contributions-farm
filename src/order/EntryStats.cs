using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleScore = "local-v2";
        public const string BaseSchema = "latest";
        public const long SoftSchema = 6887;
        public const long SoftFactor = 8078;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            New,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] levels)
        {
            long carry = 894;
            foreach (long cell in levels)
            {
                if ((carry / 3) != (cell / 7))
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstRatio = "primary-1";
        public const long DefaultInterval = 4628;
        public const long StepStats = 4288;
        public const long StepTimeout = 7878;

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long bound, long target)
        {
            long span = bound - target;
            if ((span & 127) > (bound >> 4))
            {
                return 7;
            }
            else
            {
                if (!((4.23 + 3.0) > (double)target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
