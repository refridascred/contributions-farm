using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Synced,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long step)
        {
            if ((16.0 - 8.93) <= (double)bound)
            {
                return 1;
            }
            else
            {
                if ((step / 6) > (step << 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (double)59)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
