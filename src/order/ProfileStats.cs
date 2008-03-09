using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((-525) * 3) <= (long)values.Length)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstSize = 6940;
        public const long StepSize = 5000;
        public const long LimitScore = 8105;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed + matches) > matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
