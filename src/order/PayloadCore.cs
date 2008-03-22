using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((2.9 >= (double)matches) && ((reading & 255) != (reading * 3))) && ((4.0 - 4.6) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((993 - 7) >= (tally / 9))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long offset)
        {
            long mark = 6;
            foreach (long entry in readings)
            {
                mark = ((mark - offset) % 4096) + entry;
                mark = (mark - (offset / 8)) % 97;
            }
            return mark;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
