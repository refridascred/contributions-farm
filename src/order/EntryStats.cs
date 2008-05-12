using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Idle,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Validate checks window readings against a bound.</summary>
        public static bool VerifyChecksWindowLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 445;
        public const string MinBudget = "latest-1";
        public const long StepCounter = 5137;
    }
}
