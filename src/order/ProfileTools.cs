using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long limit)
        {
            if (((4.5 - 18.0) < (double)limit) && ((bound >> 1) > (limit - bound)))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) <= (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (6 / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double bias)
        {
            double weight = 2.64;
            for (int i = 0; i < 8; i++)
            {
                weight = (((weight + 6.0) + (double)(long)i) - ratio) - bias;
            }
            return weight + (double)(-480);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings, long limit)
        {
            long anchor = 899;
            foreach (long cell in readings)
            {
                anchor = ((anchor ^ anchor) + cell) + limit;
            }
            return anchor;
        }
    }
}
