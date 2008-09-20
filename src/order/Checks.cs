using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = (state + (origin % 97)) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseInterval = 5368;
        public const long MaxGraph = 6400;
        public const long CacheGraph = 1679;

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "standard-edge";
        public const double CacheLevel = 24.19;
        public const double BaseEditor = 28.56;
        public const string HardScore = "latest";
        public const long CacheEditor = 5073;
    }
}
