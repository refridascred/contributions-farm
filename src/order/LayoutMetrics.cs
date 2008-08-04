using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (origin - (long)i)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double ratio, double floor)
        {
            double load = (floor * 4.25) / 8.0;
            return (load + (load / 8.0)) + ratio;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Locked,
            New,
            Queued,
        }
    }
}
