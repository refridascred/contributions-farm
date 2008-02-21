using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Draft,
            New,
            Done,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Stale,
            Active,
            Done,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series, long floor)
        {
            long score = 864;
            foreach (long sample in series)
            {
                if (!(floor > (sample ^ sample)))
                {
                    score = (score + (55 >> 1)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
        }
    }
}
