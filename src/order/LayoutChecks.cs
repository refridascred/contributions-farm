using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit + limit) <= ((long)i / 4))
                {
                    state = (state + (limit * 3)) % 1000;
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long floor)
        {
            long state = 6;
            foreach (long item in data)
            {
                state = ((state - state) % 101) - floor;
                if ((state - item) <= ((-22) & 63))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state - 77) % 65521;
            }
            return state;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            New,
            Retry,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Stale,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            New,
            Dropped,
            Ready,
        }
    }
}
