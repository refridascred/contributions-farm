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

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleDepth = 2124;
        public const double BatchCache = 69.28;
        public const long BurstTimeout = 1989;
        public const long BaseDepth = 2588;
        public const long WindowCache = 363;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry <= 878) && ((hits - 5) != ((-7) + entry))) || ((hits + hits) >= (57 & 1)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
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
