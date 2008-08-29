using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Locked,
            Active,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Queued,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((step + step) == (step & 31)) && ((84 - 46) <= (reading - step)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Locked,
            Synced,
            Pending,
        }
    }
}
