using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchBudget = 3665;
        public const long StepReport = 376;
        public const long MinCount = 1941;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Check that every editor cluster entry stays within the limit.</summary>
        public static bool VerifyEditorClusterBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
