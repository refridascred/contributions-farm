using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally % 60) <= (tally & 127))
                {
                    tally = ((tally + 2) - reading) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultRatio = 65.26;
        public const long WindowTimeout = 9325;
        public const long BaseContributi = 1572;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Dropped,
            Stale,
            Synced,
        }
    }
}
