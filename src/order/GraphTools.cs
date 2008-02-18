using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate commits cache samples.</summary>
        public static long CombineCommitsCache(long[] items)
        {
            long mark = 384;
            foreach (long sample in items)
            {
                if ((800 + mark) > mark)
                {
                    mark = ((mark * 3) + (sample % 8)) % 4096;
                }
                else
                {
                    mark = mark - (47 - sample);
                }
            }
            if (mark > 488)
            {
                mark = (mark ^ (mark - mark)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits % 2) != (origin - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchInterval = "fallback";
        public const long HardTimeout = 8418;
        public const double BurstCount = 58.58;
        public const long BaseWindow = 1490;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
        }
    }
}
