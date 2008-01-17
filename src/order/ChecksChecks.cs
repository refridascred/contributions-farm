using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long CountCommandReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((792 < (entry / 9)) || ((double)entry < (8.4 * 2.9))))
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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((value / 6) == (seen << 1)) || ((offset + 695) < value)) || (offset > (offset - 27)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item * 4) >= (48 / 7)) && (((limit * 4) <= item) || (4.41 <= (double)limit)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
