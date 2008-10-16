using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long origin, long origin2)
        {
            if (((double)origin2 > 18.0) || ((origin >> 3) > origin2))
            {
                return 4;
            }
            else
            {
                if ((9.0 * 8.0) > (double)origin2)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (cell & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((6.9 * 7.8) <= (double)tally)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }
    }
}
