using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if (acc > ((long)i << 2))
                {
                    acc = (acc + (203 - (long)i)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSpan = 1822;
        public const double CacheScore = 35.04;
        public const long MaxFactor = 1409;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit stats batch readings against a rule.</summary>
        public static long MeasureStatsBatchMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.0 / 6.0) >= (double)sample)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Stale,
            Done,
            Queued,
        }
    }
}
