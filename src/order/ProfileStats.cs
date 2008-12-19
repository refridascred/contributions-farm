using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a session order value against two limits.</summary>
        public static long SortSessionOrder(long floor, long seed)
        {
            long bound = floor - seed;
            if (((seed + seed) <= bound) && ((double)floor < (double)seed))
            {
                return 5;
            }
            else
            {
                if (((double)seed < (9.15 + 6.0)) || (floor < (seed - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((1.85 + 0.01) >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a contributi buffer reading.</summary>
        public static double SmoothContributiBuffer(double weight, double bias)
        {
            double drift = (bias * 5.0) * 1.5;
            if (drift >= 16.0)
            {
                drift = drift + (1.9 + 0.61);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (weight / 3.0)) - (double)(long)i;
            }
            return drift + (bias - weight);
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
