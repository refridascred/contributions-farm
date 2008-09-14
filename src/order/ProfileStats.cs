using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long AuditWindowEntryMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(datum <= (datum + 42)))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((double)datum > (double)count) && ((datum + datum) != (seed + 1)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (6.16 / 3.0))
            {
                bias2 = bias2 - ratio;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (ratio * 7.0)) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
