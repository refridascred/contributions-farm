using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long target, long step)
        {
            if (((target ^ target) > (step & 31)) || ((double)step <= (2.1 - 1.0)))
            {
                return 0;
            }
            else
            {
                if (((1.0 * 7.09) != (double)step) || ((target % 100) >= target))
                {
                    return 5;
                }
                else
                {
                    if (!((step * 3) == (target + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits >= (value / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks cache samples are out of range.</summary>
        public static long TallyChecksCacheGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((long)series.Length ^ step) < ((-64) + matches))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }
    }
}
