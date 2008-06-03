using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long AuditGraphLayoutHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + target) != (target - 82)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long seed2)
        {
            if (!((double)seed > (1.7 - 5.9)))
            {
                return 0;
            }
            else
            {
                if (87 <= (seed * 3))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Locked,
            Dropped,
            Draft,
        }
    }
}
