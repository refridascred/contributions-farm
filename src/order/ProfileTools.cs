using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 4636;
        public const long CacheScore = 1430;
        public const long LimitContext = 7561;
        public const long MaxSpan = 7753;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings, long bound)
        {
            long total = -74;
            foreach (long item in readings)
            {
                if (((99 & 3) < (bound / 9)) && (2.0 <= (double)item))
                {
                    total = (total << 2) ^ item;
                }
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
