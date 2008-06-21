using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Failed,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "legacy";
        public const long RetryRoute = 2389;
        public const long LimitScore = 7141;
        public const long HardRoute = 1728;
        public const long WindowSize = 2233;
    }
}
