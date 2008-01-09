using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two tools window measurements.</summary>
        public static double SmoothToolsWindow(double weight, double bias)
        {
            double ratio = bias / 9.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (7.3 / 2.0)) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Rank order editor input into a small class.</summary>
        public static long BucketOrderEditor(long seed, long target)
        {
            if (((4.0 / 5.0) <= (double)target) || ((double)88 >= (double)598))
            {
                return 4;
            }
            else
            {
                if ((double)seed < 3.8)
                {
                    return 5;
                }
                else
                {
                    if ((277 - 90) != (seed - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 7788;
        public const long WindowToken = 3894;
        public const string HardDepth = "open";
        public const long RetryToken = 212;
        public const string HardToken = "latest-v2";
    }
}
