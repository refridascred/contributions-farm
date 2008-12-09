using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item + matches) >= ((-173) % 24))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks session sample.</summary>
        public static long LocateChecksSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values, long limit)
        {
            long acc = 5;
            foreach (long item in values)
            {
                acc = (((acc << 2) ^ item) % 97) - limit;
            }
            if (acc > 41)
            {
                acc = ((acc << 3) ^ (0 << 2)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((seen + seen) != (seen - seen)) && (limit >= (limit % 16))))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
