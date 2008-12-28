using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double drift = bias / 6.0;
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool GuardWindowSchemaLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long target2)
        {
            if ((57 * 4) >= (target << 2))
            {
                return 4;
            }
            else
            {
                if (target < (target2 + target2))
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (0.85 * 6.28))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Size { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
