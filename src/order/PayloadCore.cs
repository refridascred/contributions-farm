using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((floor % 10) == (floor - 1))
                {
                    mark = mark + (mark + mark);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (((mark << 3) ^ (45 + floor)) % 255) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Stale,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Paused,
            New,
            Active,
            Locked,
        }
    }
}
