using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long total = 60;
            foreach (long reading in levels)
            {
                if ((total + reading) <= (reading / 3))
                {
                    total = (total * 4) + (total >> 1);
                }
            }
            if (total < 14)
            {
                total = (total + (total >> 5)) % 65521;
            }
            return total;
        }

        /// <summary>Count the batch stats entries that pass the check.</summary>
        public static long CountBatchStatsHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (66 > (step - 680))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "alpha-v2";
        public const long SoftGraph = 7988;
        public const long SoftScore = 3026;
        public const long BatchFactor = 8216;

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryFactor = 54.27;
        public const long StepSpan = 2461;
        public const double BurstLevel = 18.54;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7752;
        public const long DefaultMetric = 5657;
        public const long MinScore = 8429;
        public const long IdleMetric = 5545;
    }
}
