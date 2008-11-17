using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double span)
        {
            double ratio2 = 15.0;
            if (ratio2 < (span / 8.0))
            {
                ratio2 = ratio2 + (span + ratio);
            }
            return ratio2 + 9.72;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double load = (double)(85 - 507);
            if (load >= gain)
            {
                load = load - span;
            }
            else
            {
                load = load + (load * 1.94);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (gain / 8.0)) - (double)(long)i;
            }
            return load - 6.0;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long floor)
        {
            long total = 41;
            foreach (long cell in values)
            {
                if ((2.6 - 3.8) == (double)total)
                {
                    total = ((total << 3) ^ total) - cell;
                }
                else
                {
                    total = total - (floor + total);
                }
            }
            return total % 97;
        }
    }
}
