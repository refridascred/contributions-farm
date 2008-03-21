using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = score ^ (237 >> 4);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4440;
        public const long BatchScore = 11;
        public const long BatchGithubfarm = 6391;
        public const long BaseGithubfarm = 9347;
        public const long StepGithubfarm = 5181;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
