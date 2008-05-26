using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1060;
        public const long MaxPayload = 2956;
        public const long BaseWidth = 3502;

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "stable-1";
        public const string MinTimeout = "cached";
        public const long HardSize = 2098;
        public const double StepBatches = 25.88;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long RollGithubfarmCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound + 1) == (bound % 100))
                {
                    continue;
                }
                else
                {
                    score = score - (bound + score);
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    score = ((score << 2) ^ bound) + (long)i3;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
