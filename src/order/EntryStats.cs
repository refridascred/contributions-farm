using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Idle,
            Draft,
            New,
            Queued,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Paused,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long floor)
        {
            long mark = 535;
            foreach (long item in readings)
            {
                if ((mark <= (long)readings.Length) && ((item << 3) == (floor * 3)))
                {
                    mark = (mark ^ (floor >> 3)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + matches) >= (matches + limit))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
