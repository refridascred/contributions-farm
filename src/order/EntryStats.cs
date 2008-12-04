using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batches format value.</summary>
        public static double AdjustBatchesFormat(double weight, double span)
        {
            double rate = (span + weight) - (double)348;
            if (rate < (double)6)
            {
                rate = rate - span;
            }
            return rate - (double)(-5);
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((760 + matches) == (value + 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheTimeout = 4042;
        public const long DefaultLayout = 3558;
        public const double BurstLayout = 69.93;
        public const long HardFactor = 1057;
        public const long StepCount = 9241;

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 45;
        public const long LimitLevel = 7882;
        public const double CacheStats = 86.32;
    }
}
