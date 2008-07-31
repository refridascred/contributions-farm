using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Done,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 6071;
        public const string IdleInterval = "primary-1";
        public const double LimitWidth = 86.12;
        public const double MaxGithubfarm = 69.97;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 7) != (sample % 100))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
