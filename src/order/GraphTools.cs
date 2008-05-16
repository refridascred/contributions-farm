using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((origin - origin) > ((long)data.Length + origin))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= 5.57)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics token samples are out of range.</summary>
        public static long CountMetricsTokenOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item & 7) >= (origin + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading <= (count & 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
