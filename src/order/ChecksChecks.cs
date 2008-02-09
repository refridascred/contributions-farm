using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 1978;
        public const double MinGithubfarm = 55.45;
        public const string CacheGithubfarm = "latest-edge";

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long offset)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                if (!((sample - sample) <= (33 % 2)))
                {
                    mark = (((mark * 2) + (mark * 3)) % 65521) - offset;
                }
            }
            return mark % 97;
        }
    }
}
