using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit report checks readings against a rule.</summary>
        public static long CountReportChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum <= (tally >> 4))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metric filter readings.</summary>
        public static long PairMetricFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Done,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "stable-1";
        public const long CacheBatch = 7449;
        public const long HardDepth = 5038;
        public const long RetryBatch = 7871;
        public const long BaseBatch = 8210;
    }
}
