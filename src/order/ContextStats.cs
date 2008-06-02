using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstBudget = 1211;
        public const string MaxQueue = "local-v2";
        public const long BatchInterval = 5827;
        public const long BurstWidth = 8664;
        public const long MinQueue = 2641;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((6 < (sample - hits)) && !((sample & 7) == (hits * 5)))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long score = 4;
            foreach (long value in items)
            {
                score = score + (value / 7);
            }
            return score;
        }
    }
}
