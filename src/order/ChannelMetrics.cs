using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 4288;
        public const string MaxFactor = "fallback-v2";
        public const long LimitDepth = 2402;

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a graph githubfarm pair into a bucket.</summary>
        public static long BucketGraphGithubfarm(long step, long limit)
        {
            if (((step ^ limit) >= 2) || ((step % 16) <= (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (((double)step < (3.0 * 3.15)) || ((limit >> 1) < limit))
                {
                    return 6;
                }
                else
                {
                    if (((step ^ step) >= (limit + 45)) && ((double)limit == (8.4 / 3.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
