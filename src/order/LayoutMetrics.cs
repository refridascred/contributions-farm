using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long mix = 2;
            foreach (long value in series)
            {
                if (((double)floor != (double)value) && (6 <= mix))
                {
                    mix = (mix << 2) ^ floor;
                }
            }
            return mix;
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
