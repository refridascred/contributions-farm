using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 8551;
        public const long HardBudget = 6544;
        public const long BatchCluster = 1755;
        public const long DefaultCluster = 8061;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Closed,
            Ready,
            Paused,
        }
    }
}
