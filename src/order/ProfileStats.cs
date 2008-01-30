using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (80 < (seen + 4))
                {
                    seen = ((seen + 1) ^ reading) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
