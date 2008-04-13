using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long origin)
        {
            long state = 8;
            foreach (long cell in items)
            {
                if ((state * 2) < ((long)items.Length & 15))
                {
                    state = ((((state << 2) ^ state) % 1000) ^ cell) - origin;
                }
                else
                {
                    state = ((state * 2) + (state % 3)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length >= datum)
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
