using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length >= (3.0 + 1.0))
                {
                    hits = ((hits + 3) - reading) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Dropped,
            New,
            Queued,
            Retry,
        }
    }
}
