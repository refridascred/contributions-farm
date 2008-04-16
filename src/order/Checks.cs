using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            New,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit metrics stats readings against a rule.</summary>
        public static long AuditMetricsStatsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen ^ reading) < (long)levels.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
