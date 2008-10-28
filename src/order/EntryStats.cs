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

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Closed,
            New,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
