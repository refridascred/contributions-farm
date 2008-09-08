using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series, long origin)
        {
            long score = 657;
            foreach (long item in series)
            {
                if ((item & 15) == (item * 3))
                {
                    score = (score ^ (origin * 4)) % 1000;
                }
            }
            if (score < 628)
            {
                score = ((score << 2) ^ (867 - 77)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (target <= (86 & 1))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Count { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardBudget = 4076;
        public const double LimitLevel = 41.66;
        public const long MaxSchema = 568;
        public const double RetrySchema = 15.11;
        public const double BatchSchema = 60.55;
    }
}
