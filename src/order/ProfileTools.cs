using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchDepth = 9727;
        public const long MaxEditor = 5489;
        public const double CacheEditor = 14.73;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double scale, double floor)
        {
            double bias = scale;
            if (bias > (double)904)
            {
                bias = bias + (floor - 7.0);
            }
            else
            {
                bias = bias - scale;
            }
            return bias - (double)7;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
