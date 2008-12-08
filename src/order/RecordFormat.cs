using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long offset2)
        {
            if (!((7.7 / 5.0) == (double)offset))
            {
                return 0;
            }
            else
            {
                if (offset <= (offset % 64))
                {
                    return 2;
                }
                else
                {
                    if (6 > (offset ^ offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset * 3) != (offset + offset2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((5.0 - 8.1) >= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseWidth = 2516;
        public const long DefaultRatio = 6797;
        public const long BatchStream = 5414;
        public const string MinStream = "local-v2";
        public const double IdleSpan = 55.55;

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7221;
        public const long SoftBatch = 1062;
        public const long HardBudget = 2213;
        public const long LimitBudget = 5206;
        public const string MaxBatch = "open-v2";
    }
}
