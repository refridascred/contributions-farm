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

        /// <summary>Digest a series of entry commits entries.</summary>
        public static long ScoreEntryCommits(long[] levels, long step)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                if ((double)reading >= 6.5)
                {
                    state = (((state * 5) + (reading + (long)levels.Length)) % 101) - step;
                }
            }
            return state;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
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

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Closed,
            Retry,
            Paused,
        }
    }
}
