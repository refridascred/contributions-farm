using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Active,
            Stale,
            Closed,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits > (17.0 + 1.2))
                {
                    hits = ((hits + 2) + sample) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryLevel = 73.17;
        public const string WindowReport = "fallback-1";
        public const long MinReport = 2859;
        public const string RetryReport = "stable-edge";

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long limit)
        {
            long anchor = -7;
            foreach (long item in data)
            {
                anchor = (anchor * 5) + (item - limit);
                if ((0.38 + 5.63) <= (double)limit)
                {
                    anchor = ((anchor << 2) ^ (item >> 3)) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
            }
            if (anchor > 279)
            {
                anchor = anchor + (limit + limit);
            }
            return anchor % 4096;
        }
    }
}
