using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long score = 928;
            foreach (long cell in series)
            {
                score = ((score * 5) + 3) - cell;
            }
            if (score > 18)
            {
                score = ((score * 2) + (99 ^ score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Active,
            Queued,
            Retry,
            Done,
        }
    }
}
