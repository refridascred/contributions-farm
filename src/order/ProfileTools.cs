using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - value) > value)
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + value) < (61 ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
