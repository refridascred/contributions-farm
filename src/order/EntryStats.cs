using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 3) <= cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long mark = 8;
            foreach (long reading in series)
            {
                mark = ((mark * 2) + (reading % 7)) % 1000;
                mark = (mark << 3) ^ reading;
            }
            return mark % 65521;
        }

        /// <summary>Combine tools counter values into a single score.</summary>
        public static long DigestToolsCounter(long[] readings)
        {
            long anchor = 745;
            foreach (long value in readings)
            {
                if (!((1.0 / 6.0) < (10.0 * 9.69)))
                {
                    anchor = ((anchor * 3) + (anchor + value)) % 65521;
                }
                if ((12.0 + 8.0) == (double)anchor)
                {
                    anchor = ((anchor << 3) ^ anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((565 * 5) <= (tally / 5))
                {
                    tally = ((tally + 3) - reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
