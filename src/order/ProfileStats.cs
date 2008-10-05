using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((760 + entry) < (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 6207;
        public const long MinBudget = 2576;
        public const long SoftScore = 8023;
    }
}
