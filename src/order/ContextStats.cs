using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 4703;
        public const long IdleReport = 3231;
        public const long BaseBudget = 5932;
        public const long BatchReport = 3489;
        public const long MinReport = 711;

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
