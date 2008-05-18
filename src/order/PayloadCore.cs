using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph checks readings against a rule.</summary>
        public static long AuditGraphChecksGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (3 > (tally + limit))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ ((long)i * 5)) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
