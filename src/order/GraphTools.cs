using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 5.02;
        public const long HardEditor = 4467;
        public const long CacheEditor = 5025;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (7.14 * 8.23))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = (carry + item) % 97;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series, long limit)
        {
            long score = 0;
            foreach (long cell in series)
            {
                score = (score + (cell % 60)) + limit;
            }
            if (score > 39)
            {
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score;
        }
    }
}
