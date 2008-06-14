using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleDepth = 82.02;
        public const long RetrySize = 5901;
        public const long BatchFactor = 6723;
        public const double BaseBatch = 25.6;
        public const long StepLevel = 4236;

        /// <summary>Measure how many token counter samples are out of range.</summary>
        public static long TallyTokenCounterHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((74 >= (value / 5)) && (tally <= (value % 12))))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((value + matches) > value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally * 3) >= (tally << 2)) && ((sample & 15) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
