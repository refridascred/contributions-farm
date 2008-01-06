using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit format token readings against a rule.</summary>
        public static long MeasureFormatTokenMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (13.0 * 3.9))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWidth = 74.47;
        public const double MinWindow = 18.55;
        public const double BurstRatio = 3.57;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (!(bound2 >= (bound - limit)))
            {
                return 3;
            }
            else
            {
                if ((3 + limit) < (bound % 2))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
