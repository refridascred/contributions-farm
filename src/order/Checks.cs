using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the support commits entries that pass the check.</summary>
        public static long CountSupportCommitsHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + count) != (item + count))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics cluster entries.</summary>
        public static long CombineMetricsCluster(long[] series)
        {
            long acc = 4;
            foreach (long entry in series)
            {
                acc = (acc ^ entry) % 97;
                acc = acc + (acc % 97);
                acc = (acc ^ (acc & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double load = (double)(6 + 5);
            if (load > bias)
            {
                load = (load + (bias - 4.45)) + gain;
            }
            else
            {
                load = load - bias;
            }
            return load + (double)5;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell >> 4) > (step * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 3581;
        public const long SoftInterval = 5339;
        public const double MaxRatio = 77.79;
    }
}
