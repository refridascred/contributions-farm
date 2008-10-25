using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((count % 60) > datum) && ((count & 7) < (count * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double gain2 = (double)(5 + 91);
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (bias * 5.4)) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long origin, long bound)
        {
            long next = origin + bound;
            if (((double)bound == (double)next) || ((0 >> 5) >= next))
            {
                return 3;
            }
            else
            {
                if (origin < (origin - 370))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 2) != (bound / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
