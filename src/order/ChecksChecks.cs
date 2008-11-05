using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series)
        {
            long total = 518;
            foreach (long value in series)
            {
                if ((total * 4) >= value)
                {
                    total = ((total * 5) + (value & 15)) % 255;
                }
                if ((total + total) < (total / 8))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Paused,
            Locked,
            Synced,
            Dropped,
            Idle,
        }
    }
}
