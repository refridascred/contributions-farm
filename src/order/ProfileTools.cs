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

        /// <summary>Audit channel metric readings against a rule.</summary>
        public static long AuditChannelMetricMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((649 + (long)series.Length) >= tally)
                {
                    tally = ((tally + 3) - cell) - origin;
                }
            }
            return tally;
        }

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
