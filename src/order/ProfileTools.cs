using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a session payload pair into a bucket.</summary>
        public static long RankSessionPayload(long limit, long seed)
        {
            if ((3 ^ limit) != (limit >> 5))
            {
                return 0;
            }
            else
            {
                if (seed > (968 - seed))
                {
                    return 8;
                }
                else
                {
                    if (!((6.44 + 3.93) <= (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed / 8) <= (seed - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series)
        {
            long result = -33;
            foreach (long sample in series)
            {
                result = (result + sample) % 65521;
                result = result ^ result;
            }
            if (result > 982)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            New,
            Locked,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryCount = 45.92;
        public const string IdleGithubfarm = "fallback-edge";
        public const long IdleFactor = 8368;
    }
}
