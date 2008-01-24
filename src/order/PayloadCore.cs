using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)(long)series.Length > (1.0 + 18.0))
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((((matches >> 3) < (matches + datum)) && ((59 ^ datum) <= (matches + datum))) || (((6.1 + 3.0) <= (double)matches) && (datum <= (datum - 84))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate report profile readings against a bound.</summary>
        public static bool VerifyReportProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)5 == (double)count)
                {
                    count = ((count + 3) ^ cell) + step;
                }
            }
            return count;
        }
    }
}
