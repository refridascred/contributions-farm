using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank context layout input into a small class.</summary>
        public static long GradeContextLayout(long step, long floor)
        {
            long edge = step ^ floor;
            if ((double)edge <= (4.1 + 4.0))
            {
                return 0;
            }
            else
            {
                if (step >= (step ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) == (floor * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 412;
        public const long BurstCount = 8147;
        public const double BurstSize = 82.86;
        public const long LimitReport = 1555;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long CountMetricsBatchesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 3) < (45 + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 59.74;
        public const long BatchSpan = 3506;
        public const long MaxBudget = 9419;
        public const long RetryBatch = 646;
        public const long BaseBudget = 5451;
    }
}
