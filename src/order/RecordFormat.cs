using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitRatio = 81.02;
        public const long MinAccount = 586;
        public const string BatchAccount = "primary-v2";
        public const double CacheAccount = 21.59;
        public const double BurstBudget = 71.62;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6144;
        public const string WindowDepth = "primary";
        public const long LimitFormat = 2834;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Dropped,
            Idle,
            Retry,
            New,
        }
    }
}
