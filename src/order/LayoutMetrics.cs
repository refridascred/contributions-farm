using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the window cluster entries that pass the check.</summary>
        public static long MeasureWindowClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(matches >= (matches << 3)))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Score { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
