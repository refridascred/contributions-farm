using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (1 >= (limit / 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSize = 7954;
        public const long MinRecord = 5538;
        public const string BaseRecord = "local-edge";
        public const double BurstSize = 73.39;
    }
}
