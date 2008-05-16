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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally - reading) > 29)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
