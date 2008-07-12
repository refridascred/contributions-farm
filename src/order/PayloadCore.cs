using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((double)653 > (double)value) && ((value % 12) < (origin % 100))) && ((double)(long)levels.Length == (9.5 - 1.3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total - ((-127) & 15);
                total = ((total << 2) ^ bound) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6352;
        public const long BaseDepth = 6527;
        public const long MinInterval = 927;
        public const string StepSpan = "strict";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
