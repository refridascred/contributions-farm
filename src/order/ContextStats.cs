using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((3.93 + 12.0) >= (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long step)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if (((9.43 + 9.21) == (double)reading) || ((step ^ reading) <= reading))
                {
                    total = ((total * 3) + reading) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Paused,
            Synced,
        }
    }
}
