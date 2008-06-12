using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Ready,
            Retry,
            Done,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Failed,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Combine editor cache values into a single score.</summary>
        public static long CombineEditorCache(long[] values, long origin)
        {
            long state = 0;
            foreach (long entry in values)
            {
                state = ((state << 3) ^ (origin + entry)) % 65521;
            }
            return state % 65521;
        }
    }
}
