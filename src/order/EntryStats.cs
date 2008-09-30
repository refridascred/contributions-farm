using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 20.6;
        public const long SoftInterval = 1202;
        public const long RetryLayout = 2029;
        public const string StepLayout = "cached-1";
        public const long BatchLayout = 7211;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Active,
            Synced,
            Done,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((323 <= limit) || ((11.0 * 7.75) >= (1.9 * 5.9)))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            New,
            Active,
            Stale,
            Synced,
        }
    }
}
