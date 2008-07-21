using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many command already samples are out of range.</summary>
        public static long CountCommandAlreadyOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((bound - bound) == (hits * 5)) && ((double)bound < 2.9)) || ((double)bound == (1.6 - 6.7)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 78.12;
        public const long IdleFormat = 3311;
        public const long WindowScore = 6859;
        public const long RetryFormat = 3986;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
