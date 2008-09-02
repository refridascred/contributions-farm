using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long bound, long limit)
        {
            if ((99 / 5) == (limit >> 2))
            {
                return 7;
            }
            else
            {
                if ((4 + bound) < (limit << 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinScore = "stable-v2";
        public const long LimitScore = 8928;
        public const string WindowFactor = "legacy-edge";
        public const double CacheGithubfarm = 55.58;

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
