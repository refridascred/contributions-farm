using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] values)
        {
            long carry = 638;
            foreach (long cell in values)
            {
                if ((carry << 2) > carry)
                {
                    carry = ((carry * 3) + (cell - cell)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Active,
            Pending,
            Synced,
            Retry,
        }
    }
}
