using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Ready,
            New,
            Queued,
            Retry,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long mark = 810;
            foreach (long cell in items)
            {
                mark = (mark - cell) % 255;
                mark = (mark ^ mark) % 101;
                mark = ((mark << 2) ^ (mark >> 4)) % 255;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstBudget = 8771;
        public const long BaseGithubfarm = 4684;
        public const string LimitGithubfarm = "cached-1";
        public const double StepLevel = 7.18;
        public const long MinBudget = 6452;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
