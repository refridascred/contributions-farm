using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long acc = 38;
            foreach (long item in readings)
            {
                acc = (acc + (74 + item)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series, long limit)
        {
            long mark = 8;
            foreach (long sample in series)
            {
                if ((sample + limit) == (limit << 1))
                {
                    mark = ((mark << 3) ^ sample) % 97;
                }
                if ((double)limit >= (9.0 - 2.2))
                {
                    mark = mark + (limit + (long)series.Length);
                }
            }
            if (mark > 1)
            {
                mark = mark - (limit - limit);
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBudget = 93.41;
        public const long DefaultRatio = 8846;
        public const long StepRatio = 7982;
        public const long BatchBuffer = 653;
        public const long BatchSpan = 4684;
    }
}
