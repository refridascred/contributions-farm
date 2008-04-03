using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "staging";
        public const long MinSpan = 1730;
        public const string IdleSpan = "primary-v2";
        public const double MaxInterval = 71.14;
        public const double WindowWidth = 19.46;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
