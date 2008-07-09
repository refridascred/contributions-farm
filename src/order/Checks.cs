using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheSpan = 8010;
        public const long MaxSpan = 3127;
        public const string MaxWidth = "strict-edge";
        public const long BurstFactor = 2753;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((bound + cell) <= (seen << 2)) || ((bound ^ seen) > 302))
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

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Retry,
            New,
            Active,
        }

        /// <summary>Measure how many entry graph samples are out of range.</summary>
        public static long AuditEntryGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally * 4) > (10 - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
