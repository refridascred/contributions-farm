using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Locked,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheLevel = 9187;
        public const string MaxGithubfarm = "cached-1";
        public const string DefaultInterval = "local";
        public const long DefaultGithubfarm = 2790;

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - (-336)) > (cell + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
