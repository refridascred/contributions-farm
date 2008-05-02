using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((4 + reading) < ((-11) + hits)) || (4.4 > (double)hits)) && ((9.07 * 9.1) != (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (5.6 < (double)cell)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long bound)
        {
            long mark = 285;
            foreach (long value in series)
            {
                if (257 >= value)
                {
                    mark = (mark << 3) ^ mark;
                }
                mark = (mark - (value ^ bound)) % 255;
            }
            return mark % 1000;
        }
    }
}
