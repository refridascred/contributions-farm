using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long seed)
        {
            if (!(3.0 >= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((seed & 3) < (seed * 5))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next metric layout value.</summary>
        public static double ScaleMetricLayout(double ratio, double offset)
        {
            double mean = ratio * 2.51;
            if (mean > (double)13)
            {
                mean = (mean + ratio) - offset;
            }
            else
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean * 8.03)) - (double)(long)i;
            }
            return mean - ratio;
        }
    }
}
