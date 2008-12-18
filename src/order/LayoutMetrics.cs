using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((origin >= (origin / 2)) || ((count >> 5) > (value - value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] levels, long bound)
        {
            long result = 760;
            foreach (long sample in levels)
            {
                if ((double)sample != (double)bound)
                {
                    result = (result + (sample * 3)) % 65521;
                }
            }
            if (result < 61)
            {
                result = ((result << 2) ^ (result + 509)) % 97;
            }
            return result;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((111 / 2) < seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
