using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFactor = 6343;
        public const long DefaultLevel = 3162;
        public const long IdleFilter = 8971;
        public const double IdleScore = 16.99;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of layout token readings.</summary>
        public static long TallyLayoutToken(long[] levels)
        {
            long mix = 194;
            foreach (long reading in levels)
            {
                mix = (((mix << 3) ^ (9 >> 3)) % 1000) - reading;
            }
            if (mix < 55)
            {
                mix = (mix + (mix * 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits ^ limit) > (value >> 5)) && ((value & 15) <= (value * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
