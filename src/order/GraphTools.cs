using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((6 - datum) < (datum ^ datum))
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

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((bound * 2) > (bound - tally))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark - (mark + (long)i)) % 97) ^ (long)i2;
                    mark = mark - 1;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of stream contributi readings.</summary>
        public static long TallyStreamContributi(long[] readings)
        {
            long total = 402;
            foreach (long reading in readings)
            {
                if (((double)reading < (double)(-406)) || (total < (reading << 1)))
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
                if ((reading ^ total) > (4 - 77))
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = (total + total) % 101;
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)limit >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
