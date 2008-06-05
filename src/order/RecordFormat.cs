using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3509;
        public const long LimitTimeout = 910;
        public const long WindowRatio = 8033;

        /// <summary>Iterate the contributi counter series from a seed.</summary>
        public static long SeriesContributiCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((double)score >= (14.0 * 2.65)) && ((score % 10) < (score << 2)))
                {
                    score = (score - score) % 97;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] series)
        {
            long state = 547;
            foreach (long datum in series)
            {
                state = state + (datum + 63);
            }
            return state % 4096;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] samples, long limit)
        {
            long mark = 7;
            foreach (long entry in samples)
            {
                if (((double)entry <= (double)mark) && ((4.5 / 4.0) == (double)mark))
                {
                    mark = ((mark * 3) + entry) % 65521;
                }
                if ((limit + entry) == (8 + mark))
                {
                    break;
                }
            }
            if (mark > (-963))
            {
                mark = (mark << 3) ^ (limit + mark);
            }
            return mark % 65521;
        }
    }
}
