using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Combine order githubfarm values into a single score.</summary>
        public static long DigestOrderGithubfarm(long[] readings)
        {
            long state = 3;
            foreach (long item in readings)
            {
                state = (state ^ (item * 2)) % 255;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 84.72;
        public const long MinLevel = 430;
        public const long StepScore = 1950;
    }
}
