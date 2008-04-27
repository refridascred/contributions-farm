using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)step <= (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] readings)
        {
            long result = 4;
            foreach (long datum in readings)
            {
                if ((20.0 - 8.5) < (double)datum)
                {
                    result = (result ^ (25 + datum)) % 101;
                }
                else
                {
                    result = (result + (datum * 4)) % 255;
                }
            }
            if (result > 1)
            {
                result = ((result << 3) ^ (result ^ (long)readings.Length)) % 101;
            }
            return result % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (5.3 > (double)item)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits token samples.</summary>
        public static long WeighCommitsToken(long[] values)
        {
            long state = 4;
            foreach (long entry in values)
            {
                if ((entry - entry) < (state + entry))
                {
                    state = state - 7;
                }
            }
            if (state > 388)
            {
                state = (state * 3) + (state + state);
            }
            return state % 97;
        }
    }
}
