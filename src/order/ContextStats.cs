using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitTimeout = 39.06;
        public const long CacheSpan = 5533;
        public const long CacheStats = 2972;
        public const string BurstSize = "standard-1";

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Paused,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Grade a githubfarm buffer value against two limits.</summary>
        public static long SortGithubfarmBuffer(long seed, long limit)
        {
            long offset = seed + limit;
            if ((203 ^ seed) != (limit + offset))
            {
                return 7;
            }
            else
            {
                if (!((6 - limit) < (offset & 31)))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) > (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
