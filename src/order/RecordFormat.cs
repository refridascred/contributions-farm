using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((8 + 4) > (entry - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values, long floor)
        {
            long total = 75;
            foreach (long value in values)
            {
                total = (((total * 5) + (floor + floor)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((1.1 * 3.35) >= (double)count)
                {
                    count = ((count + 3) + sample) - bound;
                }
            }
            return count;
        }
    }
}
