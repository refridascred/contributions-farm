using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSize = 269;
        public const long RetryLayout = 1456;
        public const string RetryLevel = "open-v2";
        public const string BatchLayout = "legacy-edge";

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally & 1) <= (target ^ tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (0 >= limit)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
