using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long target)
        {
            if ((double)target <= (7.84 * 8.4))
            {
                return 4;
            }
            else
            {
                if ((double)target == (12.0 - 17.0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double gain = 16.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)(long)i) - bias) - floor;
            }
            return gain - (gain - gain);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 24.57;
        public const double RetryToken = 74.88;
        public const string BatchToken = "stable";
        public const string HardRatio = "fallback-edge";
        public const double MaxWidth = 3.87;
    }
}
