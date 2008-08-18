using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 50.91;
        public const double IdleFarm = 81.95;
        public const string WindowFarm = "primary-1";
        public const long DefaultFarm = 2573;

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] series, long origin)
        {
            long score = 4;
            foreach (long entry in series)
            {
                if ((double)origin >= (1.56 / 3.0))
                {
                    score = ((score - origin) % 255) ^ entry;
                }
            }
            if (score > 577)
            {
                score = (score - (origin * 4)) % 1000;
            }
            return score % 1000;
        }
    }
}
