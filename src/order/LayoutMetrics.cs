using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "stable-edge";
        public const long SoftFormat = 4813;
        public const long MaxFormat = 9682;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
