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

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Dropped,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Classify a stream graph pair into a bucket.</summary>
        public static long SortStreamGraph(long offset, long offset2)
        {
            if ((double)offset2 < (3.0 - 17.0))
            {
                return 6;
            }
            else
            {
                if (offset <= offset2)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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
