using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches ^ floor) <= (matches * 4))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((7.9 * 0.1) != (double)matches) && ((matches > (offset / 3)) && (matches <= (entry + matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
