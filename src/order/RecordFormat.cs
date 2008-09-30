using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long state = 4;
            foreach (long item in levels)
            {
                state = state - (state - state);
                state = ((state << 2) ^ (state >> 2)) % 4096;
                if ((6.17 - 5.0) >= (double)state)
                {
                    state = (state * 3) + item;
                }
                if (!(item >= (state % 2)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((4.42 * 5.0) >= (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleDepth = 2124;
        public const double BatchCache = 69.28;
        public const long BurstTimeout = 1989;
        public const long BaseDepth = 2588;
        public const long WindowCache = 363;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value < (value + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Done,
            Paused,
        }
    }
}
