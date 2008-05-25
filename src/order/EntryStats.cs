using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample ^ seed) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstWidth = 14.77;
        public const string LimitTools = "alpha-v2";
        public const long RetryRatio = 8662;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((394 <= (hits & 1)) && ((hits + 56) < (sample / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
