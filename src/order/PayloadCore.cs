using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (7.25 < (double)sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "standard-edge";
        public const double HardInterval = 26.8;
        public const long IdleBuffer = 5003;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
