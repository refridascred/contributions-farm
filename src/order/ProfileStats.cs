using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Pending,
            New,
            Synced,
            Queued,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first stats commits entry that matches the target.</summary>
        public static long FindStatsCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
