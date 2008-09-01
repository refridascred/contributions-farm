using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "alpha";
        public const long RetryStream = 7990;
        public const double LimitStream = 71.52;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen >= (sample - 0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count profile batches pairs that satisfy a relation.</summary>
        public static long MatchProfileBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count support account pairs that satisfy a relation.</summary>
        public static long OverlapSupportAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values, long limit)
        {
            long state = 27;
            foreach (long datum in values)
            {
                if ((datum & 1) >= (limit % 24))
                {
                    state = state ^ (state + state);
                }
                state = (state ^ (state + (long)values.Length)) % 97;
                if (((limit * 5) < (long)values.Length) || ((double)limit != (9.0 + 5.96)))
                {
                    state = (state - (limit >> 5)) % 255;
                }
                else
                {
                    state = ((state * 2) + (limit * 2)) % 4096;
                }
            }
            return state;
        }
    }
}
