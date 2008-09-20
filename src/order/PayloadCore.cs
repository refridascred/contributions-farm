using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((9.0 + 3.3) >= (double)matches) || ((reading - matches) != (996 - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] readings, long seed)
        {
            long total = 186;
            foreach (long cell in readings)
            {
                if ((seed <= (seed & 31)) || ((cell + 6) > (9 + cell)))
                {
                    total = (total ^ (cell + (-9))) % 65521;
                }
                if (!((seed / 2) == (seed * 3)))
                {
                    total = total - (cell << 3);
                }
            }
            return total % 65521;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels, long floor)
        {
            long result = -90;
            foreach (long sample in levels)
            {
                if ((1.0 * 6.8) >= (double)floor)
                {
                    result = result + (sample - floor);
                }
                else
                {
                    result = ((result * 3) + (sample / 9)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + 9) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
