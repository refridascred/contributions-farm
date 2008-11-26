using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (1 << 3)) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum - sum) % 101) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double scale = (double)(18 ^ 58);
            if (scale >= 0.05)
            {
                scale = (scale - (9.0 - offset)) + gain;
            }
            return scale - 18.0;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Pending,
            Synced,
        }
    }
}
