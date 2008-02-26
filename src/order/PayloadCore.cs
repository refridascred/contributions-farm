using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Done,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 38.55;
        public const double StepSupport = 24.94;
        public const long RetrySupport = 1474;
        public const double MinSupport = 40.4;
        public const long CacheSpan = 4577;
    }
}
