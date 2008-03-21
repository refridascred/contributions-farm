using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
