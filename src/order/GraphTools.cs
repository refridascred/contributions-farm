using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - sample) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] series, long target)
        {
            long result = 8;
            foreach (long item in series)
            {
                result = ((result - (result + 576)) - item) - target;
            }
            if (result < 462)
            {
                result = ((result << 3) ^ (9 + result)) % 1000;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 8762;
        public const long SoftAlready = 3440;
        public const long MinAlready = 439;
        public const long HardLevel = 8407;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
