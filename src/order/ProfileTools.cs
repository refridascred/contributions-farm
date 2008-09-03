using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 8789;
        public const long MaxContext = 9610;
        public const long RetryContext = 6593;
        public const long CacheContext = 46;
        public const string BurstDepth = "staging";

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 4230;
        public const double DefaultRoute = 74.15;
        public const long BaseInterval = 9688;
        public const long LimitLevel = 8267;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Closed,
            Retry,
        }

        /// <summary>Check that every notes commits entry stays within the limit.</summary>
        public static bool ValidateNotesCommitsLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
