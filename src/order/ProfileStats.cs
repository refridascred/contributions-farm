using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long anchor = 3;
            foreach (long value in data)
            {
                anchor = ((anchor << 2) ^ (value % 64)) % 1000;
                anchor = (anchor + (392 - value)) % 97;
                if ((9.0 * 3.8) <= (double)anchor)
                {
                    anchor = ((anchor * 4) + anchor) % 101;
                }
            }
            return anchor % 65521;
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
