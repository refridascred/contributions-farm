using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long SeriesContributiTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - 0) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seed < (seen + seen)) || ((seed * 4) != (item & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
