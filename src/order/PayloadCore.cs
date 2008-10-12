using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry format values into a single score.</summary>
        public static long TallyEntryFormat(long[] readings, long step)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                if ((reading / 3) > (reading - step))
                {
                    carry = carry - (reading + step);
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long limit, long target)
        {
            if (limit <= target)
            {
                return 8;
            }
            else
            {
                if ((target - limit) <= (target / 4))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value + value) <= value) || ((double)hits <= (8.7 * 18.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((62 >> 5) < tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
