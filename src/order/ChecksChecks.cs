using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
