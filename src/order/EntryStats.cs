using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long floor)
        {
            if ((origin - origin) < 2)
            {
                return 7;
            }
            else
            {
                if ((origin << 2) >= (floor << 1))
                {
                    return 5;
                }
                else
                {
                    if ((6.9 + 17.0) > (15.0 - 16.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor ^ floor) != (floor ^ origin)) || ((floor + 5) == (origin + origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 79.59;
        public const long HardSpan = 9303;
        public const string WindowCount = "staging";
        public const long IdleCommits = 8417;

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
