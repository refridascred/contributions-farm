using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinBudget = "stable-edge";
        public const long BaseSize = 9826;
        public const string CacheSpan = "legacy";
        public const long RetryLayout = 3771;

        /// <summary>Validate report githubfarm readings against a bound.</summary>
        public static bool ValidateReportGithubfarmRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
