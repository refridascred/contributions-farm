using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double mean = bias;
            if (mean >= (bias + bias))
            {
                mean = mean + (mean / 9.0);
            }
            else
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 9.6) + (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Grade a counter context value against two limits.</summary>
        public static long GradeCounterContext(long seed, long offset)
        {
            if (!((seed & 255) > (offset * 4)))
            {
                return 5;
            }
            else
            {
                if ((double)seed <= (1.3 * 9.5))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long offset)
        {
            if (((5.9 * 2.1) != (double)target) && (target > offset))
            {
                return 6;
            }
            else
            {
                if (!((double)offset > (5.3 - 8.89)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((7 ^ entry) <= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
