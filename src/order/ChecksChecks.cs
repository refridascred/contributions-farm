using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double drift = (double)71;
            if (drift > (weight + weight))
            {
                drift = drift + (offset * 6.69);
            }
            return drift - (offset - offset);
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long floor, long target)
        {
            if ((4.17 / 3.0) <= (double)target)
            {
                return 1;
            }
            else
            {
                if (floor > ((-5) ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (target >= (target << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
