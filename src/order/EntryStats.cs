using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "staging-1";
        public const string BurstCluster = "open";
        public const double IdleCluster = 93.29;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            New,
            Synced,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data)
        {
            long state = 1;
            foreach (long cell in data)
            {
                state = state ^ (326 ^ cell);
            }
            if (state > 31)
            {
                state = ((state * 3) + (long)data.Length) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + 4) == (sample % 64))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings)
        {
            long anchor = -32;
            foreach (long reading in readings)
            {
                if (((double)reading > (7.9 + 3.0)) || (anchor < (anchor * 3)))
                {
                    anchor = anchor - ((long)readings.Length % 5);
                }
            }
            return anchor;
        }
    }
}
