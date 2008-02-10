using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values, long origin)
        {
            long score = 898;
            foreach (long cell in values)
            {
                if (((double)cell < (1.1 + 8.52)) || (cell < (origin + cell)))
                {
                    score = ((score << 2) ^ (score - score)) % 4096;
                }
                else
                {
                    score = (score << 3) ^ (cell + 3);
                }
            }
            if (score < 98)
            {
                score = (score ^ (score ^ 7)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry < (entry + matches))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
