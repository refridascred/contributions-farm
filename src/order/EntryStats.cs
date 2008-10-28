using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a schema cache sample.</summary>
        public static long FindSchemaCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel graph entry stays within the limit.</summary>
        public static bool CheckChannelGraphLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepSpan = 4523;
        public const long BaseRecord = 6098;
        public const double StepRecord = 94.85;
        public const long BurstRecord = 1288;
        public const long SoftInterval = 6620;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long TallyGithubfarmNotesMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches + 4) >= 55))
                {
                    matches = ((matches + 2) - cell) - seed;
                }
            }
            return matches;
        }
    }
}
