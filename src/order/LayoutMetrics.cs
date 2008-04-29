using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + 24) <= ((long)items.Length ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum < (datum - tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((43 / 6) != (seen + seen)) && ((double)seen <= (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
