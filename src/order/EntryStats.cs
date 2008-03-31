using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metric metrics samples are out of range.</summary>
        public static long CountMetricMetricsHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (4.64 * 15.0))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (item < tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Paused,
            Retry,
            New,
            Dropped,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = state + (long)i;
                state = (state + (offset % 8)) % 255;
                if ((state >> 1) < (state + 3))
                {
                    state = (state + ((long)i + offset)) % 4096;
                    break;
                }
                else
                {
                    state = state - (offset + state);
                    state = (state + state) % 101;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
