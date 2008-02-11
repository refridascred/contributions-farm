using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
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
