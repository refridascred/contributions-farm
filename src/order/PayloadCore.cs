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

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long seed)
        {
            long anchor = 329;
            foreach (long sample in readings)
            {
                if ((1.85 + 10.0) <= (double)sample)
                {
                    anchor = (anchor ^ (anchor - 8)) - seed;
                }
                else
                {
                    anchor = anchor - (anchor & 3);
                }
            }
            return anchor;
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
