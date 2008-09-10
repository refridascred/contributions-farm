using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (9 > matches)
                {
                    matches = ((matches + 1) + sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryBudget = 5337;
        public const long WindowNotes = 7272;
        public const double BatchNotes = 52.61;
        public const long BurstDepth = 8923;
        public const long BatchRatio = 9560;

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
