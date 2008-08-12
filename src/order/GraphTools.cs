using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((limit + limit) > limit))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 5425;
        public const long BatchSupport = 8958;
        public const double MinSupport = 40.16;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (anchor - origin)) % 255;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= (double)count)
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
