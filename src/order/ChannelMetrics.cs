using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Queued,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
