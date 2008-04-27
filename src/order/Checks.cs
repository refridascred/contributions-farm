using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((1 - hits) <= (946 + hits))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter tools samples are out of range.</summary>
        public static long TallyFilterToolsMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches & 15) > matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long origin, long step)
        {
            if ((origin + origin) < (285 << 3))
            {
                return 0;
            }
            else
            {
                if ((origin / 3) >= (69 & 31))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "staging";
        public const double MinMetric = 54.03;
        public const long DefaultMetric = 1042;
        public const long MaxLevel = 575;
    }
}
