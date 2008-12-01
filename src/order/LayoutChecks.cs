using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double rate = gain;
            if (rate >= (double)6)
            {
                rate = (rate - (double)40) + offset;
            }
            return rate - (double)55;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((seen ^ sample) <= 76))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Retry,
            Stale,
            Active,
            Locked,
        }
    }
}
