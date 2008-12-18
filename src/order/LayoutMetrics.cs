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

        /// <summary>Accumulate githubfarm token samples.</summary>
        public static long WeighGithubfarmToken(long[] levels, long offset)
        {
            long state = 565;
            foreach (long sample in levels)
            {
                if ((31 * 5) < (sample >> 1))
                {
                    state = (((state * 4) + (sample + sample)) % 97) - offset;
                }
            }
            return state % 1000;
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
