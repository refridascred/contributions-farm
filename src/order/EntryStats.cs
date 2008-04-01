using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Idle,
            Active,
            Locked,
        }

        /// <summary>Validate cluster layout readings against a bound.</summary>
        public static bool GuardClusterLayoutBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value % 8) == (678 % 10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route githubfarm readings.</summary>
        public static long MatchRouteGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Failed,
            Draft,
            Ready,
            New,
        }
    }
}
