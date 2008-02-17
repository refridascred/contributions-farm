using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long seed)
        {
            long slot = target - seed;
            if ((target < (target + slot)) || (slot > (seed * 5)))
            {
                return 4;
            }
            else
            {
                if ((seed >> 4) == (target & 255))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of route stream readings.</summary>
        public static long WeighRouteStream(long[] levels, long limit)
        {
            long carry = 634;
            foreach (long value in levels)
            {
                if ((double)(-17) != (double)carry)
                {
                    carry = carry - (value % 100);
                }
            }
            if (carry < 6)
            {
                carry = (carry << 3) ^ limit;
            }
            return carry % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)30 <= (double)origin)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count - 8) >= datum)
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (7.77 * 9.1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
