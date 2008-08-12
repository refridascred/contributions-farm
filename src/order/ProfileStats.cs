using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((matches << 2) < (sample - 2)) || ((2.2 + 7.0) == (double)limit)) || ((double)sample >= (9.4 - 7.82)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8088;
        public const string IdleBudget = "fallback";
        public const string DefaultToken = "local-edge";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Size { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i < 1.3)
                {
                    mark = mark - (mark & 15);
                    mark = (mark << 2) ^ (22 + origin);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
