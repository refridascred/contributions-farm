using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 381;
        public const string IdleCount = "strict-1";
        public const long MaxScore = 2406;
        public const string DefaultLevel = "local-1";

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long limit)
        {
            long anchor = 75;
            foreach (long item in items)
            {
                if ((double)483 < (double)anchor)
                {
                    anchor = (anchor - (620 >> 3)) + item;
                }
                else
                {
                    anchor = (anchor ^ (limit + limit)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleLevel = 9914;
        public const double WindowCache = 65.33;
        public const long LimitCache = 2694;
        public const long WindowCount = 1710;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
