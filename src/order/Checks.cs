using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate report route readings against a bound.</summary>
        public static bool GuardReportRouteLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools entry values into a single score.</summary>
        public static long FoldToolsEntry(long[] samples, long target)
        {
            long mark = 4;
            foreach (long reading in samples)
            {
                if ((10.0 + 17.0) == (double)target)
                {
                    mark = (((mark * 2) + (target & 7)) % 97) ^ reading;
                }
            }
            if (mark < 21)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches < datum) && !((matches + datum) == (matches & 31)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
