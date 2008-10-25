using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate buffer farm samples.</summary>
        public static long TallyBufferFarm(long[] readings, long step)
        {
            long mark = 75;
            foreach (long cell in readings)
            {
                mark = ((mark * 2) + mark) - cell;
            }
            if (mark < 95)
            {
                mark = (mark - (mark + step)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long AuditChannelRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((tally + tally) < 15) || ((double)cell >= (double)tally)) && ((6.2 * 7.59) == (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen * 5) <= (datum % 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long origin)
        {
            long span = floor + origin;
            if ((origin / 8) <= 75)
            {
                return 8;
            }
            else
            {
                if (origin > (span % 5))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
