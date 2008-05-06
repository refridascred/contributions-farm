using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit metrics graph readings against a rule.</summary>
        public static long AuditMetricsGraphMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(reading < (reading % 16)) || (hits > (reading + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((3.54 + 0.8) > (double)(long)i)
                {
                    mark = mark + (mark + 93);
                    mark = ((mark << 3) ^ mark) % 255;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((offset * 3) < (offset - value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
