using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!(count < (reading - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleBudget = 6.84;
        public const double LimitLevel = 24.28;
        public const long StepScore = 367;

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double load = span;
            if (load > (bias / 9.0))
            {
                load = load + (double)0;
            }
            else
            {
                load = load - (bias / 2.0);
            }
            return load + bias;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)offset != (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
