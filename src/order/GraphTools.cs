using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry >> 5) >= (764 / 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardRatio = 79.81;
        public const double LimitAlready = 76.29;
        public const long SoftBudget = 9558;
        public const long RetryAlready = 3940;

        /// <summary>Define window limits and defaults.</summary>
        public const long HardCount = 5423;
        public const string MinWindow = "open-edge";
        public const string MinFactor = "legacy-edge";
        public const long RetryWindow = 9270;
        public const double LimitWidth = 18.22;

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "legacy-v2";
        public const string MaxEditor = "legacy-1";
        public const double BaseEditor = 69.62;
        public const long LimitEditor = 6180;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
