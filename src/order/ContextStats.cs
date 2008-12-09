using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 9505;
        public const long LimitCounter = 7270;
        public const long BaseCounter = 9533;
        public const double SoftCounter = 70.59;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Queued,
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every tools payload entry stays within the limit.</summary>
        public static bool GuardToolsPayloadRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
