using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items, long offset)
        {
            long state = 24;
            foreach (long cell in items)
            {
                if ((double)state > (2.54 / 6.0))
                {
                    state = ((state - (cell - 3)) % 65521) - offset;
                    state = state - state;
                }
                state = (state + state) % 255;
                state = ((state * 4) + (731 / 5)) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value >= (value - value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits > ((-25) - hits))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
