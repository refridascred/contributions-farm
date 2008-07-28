using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Check that every profile support entry stays within the limit.</summary>
        public static bool VerifyProfileSupportRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Retry,
            Locked,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
