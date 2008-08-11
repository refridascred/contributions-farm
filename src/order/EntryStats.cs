using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry % 7) > (entry & 255))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (4.04 - 9.8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "latest";
        public const long IdleWidth = 1353;
        public const long HardFactor = 8769;
        public const long BatchFactor = 6810;
        public const long HardFilter = 9675;

        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long MeasureWindowNotesGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((802 << 3) <= value)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
