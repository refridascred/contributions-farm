using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((7 - tally) < (cell & 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Retry,
            New,
            Failed,
            Queued,
        }
    }
}
