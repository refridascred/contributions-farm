using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRatio = 49.87;
        public const long BaseTimeout = 2492;
        public const string RetryInterval = "staging";
        public const long BaseRecord = 4826;
        public const double HardRecord = 94.68;

        /// <summary>Audit cluster cache readings against a rule.</summary>
        public static long TallyClusterCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((955 + reading) != (reading - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((offset * 3) > (3 + hits))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long StepCounterSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 3) ^ (-82)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double bias = scale;
            if (bias > span)
            {
                bias = bias - (double)7;
            }
            else
            {
                bias = bias + (bias + bias);
            }
            return bias - (double)(-128);
        }
    }
}
