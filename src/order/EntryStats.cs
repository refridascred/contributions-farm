using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Synced,
            Ready,
            New,
            Draft,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((7 - sample) < (13 >> 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
