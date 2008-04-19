using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double scale, double offset)
        {
            double scale2 = 1.42;
            return (scale2 + offset) + scale;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
