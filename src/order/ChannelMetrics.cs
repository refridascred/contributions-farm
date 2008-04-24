using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every context order entry stays within the limit.</summary>
        public static bool GuardContextOrderBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Pending,
            Retry,
            Dropped,
        }
    }
}
