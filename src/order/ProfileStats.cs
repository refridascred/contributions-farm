using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long offset)
        {
            if (!(11 < (0 + offset)))
            {
                return 3;
            }
            else
            {
                if (!((offset >> 3) >= offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 60) < (482 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two stream notes measurements.</summary>
        public static double AdjustStreamNotes(double bias, double span)
        {
            double drift = span - (17.0 * 4.29);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)563) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((9.35 / 4.0) >= (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultScore = "open";
        public const long BaseBatches = 5969;
        public const long LimitSize = 2855;
        public const long BaseWidth = 9283;
        public const long BurstBatches = 5916;
    }
}
