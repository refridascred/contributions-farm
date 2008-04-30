using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4814;
        public const string IdleCommits = "stable-edge";
        public const long BatchSize = 3676;

        /// <summary>Validate token githubfarm readings against a bound.</summary>
        public static bool VerifyTokenGithubfarmLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long result = 345;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 3) + (result * 2)) % 255) ^ (long)i;
                }
                if ((result << 3) >= 19)
                {
                    result = (result << 3) ^ (entry % 60);
                }
                else
                {
                    result = result + result;
                }
            }
            if (result < 4)
            {
                result = ((result << 2) ^ (588 * 5)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!((bound * 4) < (5 + bound)))
                {
                    mix = (mix + (mix / 4)) % 97;
                    mix = (mix + (bound + mix)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
