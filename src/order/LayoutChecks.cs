using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a command farm pair into a bucket.</summary>
        public static long RankCommandFarm(long origin, long target)
        {
            if ((target * 5) > (target + origin))
            {
                return 0;
            }
            else
            {
                if ((double)target < (4.07 + 10.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long TallySessionPayloadHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum % 97) <= target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
