using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultDepth = 672;
        public const double CacheWidth = 49.61;
        public const long BatchInterval = 2656;
        public const long RetryGithubfarm = 2765;
        public const long HardGithubfarm = 8620;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Synced,
            Paused,
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate record farm readings against a bound.</summary>
        public static bool GuardRecordFarmRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Pending,
            Draft,
            Synced,
            Closed,
        }
    }
}
