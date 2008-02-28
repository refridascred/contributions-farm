using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if (((step ^ 144) == (step + total)) && ((step ^ step) > total))
                {
                    total = (total + (step % 100)) % 255;
                }
                else
                {
                    total = ((total * 3) + (total % 16)) % 97;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many support report samples are out of range.</summary>
        public static long TallySupportReportMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (offset >= (value & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches << 2) <= (sample - offset))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits > (hits - 76)) || ((cell <= (cell / 3)) && ((cell * 4) <= cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
