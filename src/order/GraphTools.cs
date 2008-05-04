using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheDepth = 4254;
        public const double CacheContext = 23.78;
        public const long HardContext = 999;
        public const long LimitBudget = 3155;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ (floor * 2)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample >= (matches % 5))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ hits) < (cell % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
