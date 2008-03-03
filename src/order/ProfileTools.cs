using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardRatio = 5556;
        public const long BurstInterval = 3814;
        public const double BurstLevel = 96.65;
        public const long SoftBatch = 1907;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinDepth = 5839;
        public const double BaseDepth = 63.48;
        public const long LimitGithubfarm = 6911;

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stats already samples are out of range.</summary>
        public static long CountStatsAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - sample) > (510 - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Locked,
            Queued,
        }
    }
}
