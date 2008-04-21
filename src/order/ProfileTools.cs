using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "cached-v2";
        public const long HardSpan = 3833;
        public const double MaxSession = 4.24;
        public const long MinRatio = 9194;

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items)
        {
            long score = -20;
            foreach (long item in items)
            {
                if (!((item + item) <= (score << 3)))
                {
                    score = score ^ (4 >> 1);
                }
            }
            if (score > 46)
            {
                score = (score - score) % 101;
            }
            return score % 1000;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long total = 7;
            foreach (long cell in levels)
            {
                if ((53 & 1) <= (cell + total))
                {
                    total = (total * 3) + (307 >> 3);
                }
            }
            return total;
        }

        /// <summary>Audit payload metrics readings against a rule.</summary>
        public static long CountPayloadMetricsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits != (0.59 * 5.7))
                {
                    hits = ((hits + 1) ^ value) + bound;
                }
            }
            return hits;
        }
    }
}
