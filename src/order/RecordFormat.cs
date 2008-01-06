using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the stats metrics entries that pass the check.</summary>
        public static long AuditStatsMetricsHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches - target) >= (matches & 63)) && (((long)series.Length >> 1) > target))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Validate route session readings against a bound.</summary>
        public static bool ValidateRouteSessionRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((offset >> 5) >= seen))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 3;
            foreach (long item in levels)
            {
                if (!(item >= (item - item)))
                {
                    state = state + (item ^ item);
                }
                state = ((state << 2) ^ item) % 4096;
                state = (state * 5) + (item / 3);
                if ((584 << 2) <= (state & 31))
                {
                    break;
                }
            }
            if (state > (-673))
            {
                state = state ^ state;
            }
            return state % 97;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally - sample) <= (sample + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
