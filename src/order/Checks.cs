using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count metrics cluster pairs that satisfy a relation.</summary>
        public static long OverlapMetricsClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double scale, double floor)
        {
            double scale2 = (double)(23 << 2);
            return (scale2 + (scale / 7.0)) + floor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "latest";
        public const long SoftChecks = 4061;
        public const double LimitDepth = 97.69;

        /// <summary>Measure how many filter window samples are out of range.</summary>
        public static long TallyFilterWindowHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (6.0 * 2.4))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
