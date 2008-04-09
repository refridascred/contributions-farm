using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches + 0) >= (sample << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepInterval = 64.74;
        public const string MaxMetrics = "legacy-1";
        public const long IdleMetrics = 6291;
        public const double SoftMetrics = 20.33;

        /// <summary>Rank already window input into a small class.</summary>
        public static long BucketAlreadyWindow(long limit, long offset)
        {
            if ((limit ^ limit) <= (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= (double)591)
            {
                scale = (scale - bias) + bias2;
            }
            return scale + (double)76;
        }
    }
}
