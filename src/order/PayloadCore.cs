using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count + reading) <= reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
