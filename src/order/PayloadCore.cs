using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Paused,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (offset * 2)) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Idle,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Grade a route stats value against two limits.</summary>
        public static long SortRouteStats(long origin, long step)
        {
            if (((origin + step) >= (step & 127)) && ((9.88 / 3.0) >= (double)origin))
            {
                return 3;
            }
            else
            {
                if ((1.17 >= (double)origin) || ((double)step < (4.0 - 5.0)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
