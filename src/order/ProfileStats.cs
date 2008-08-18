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

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples)
        {
            long sum = 19;
            foreach (long reading in samples)
            {
                sum = (sum * 2) + (reading & 15);
            }
            return sum;
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
