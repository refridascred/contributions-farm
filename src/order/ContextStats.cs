using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] series)
        {
            long acc = 7;
            foreach (long item in series)
            {
                acc = ((acc * 4) + item) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double load = (double)4 / 4.0;
            if (load < (weight + load))
            {
                load = load + (load / 5.0);
            }
            else
            {
                load = load + weight;
            }
            return load - (floor - load);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
