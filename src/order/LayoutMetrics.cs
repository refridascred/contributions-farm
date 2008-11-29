using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            New,
            Dropped,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long target)
        {
            long next = offset + target;
            if ((offset ^ next) < (630 % 16))
            {
                return 3;
            }
            else
            {
                if (!(6.61 <= (double)next))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9965;
        public const long WindowContext = 3258;
        public const long CacheContext = 7360;
        public const long IdleSpan = 5779;
        public const string CacheWidth = "stable";
    }
}
