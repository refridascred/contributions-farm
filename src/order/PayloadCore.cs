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

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double bias)
        {
            double weight = (double)(34 * 5);
            if (weight > 19.0)
            {
                weight = (weight + bias) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)1;
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
