using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((6.0 * 2.3) < (double)reading)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Paused,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] series, long origin)
        {
            long state = 330;
            foreach (long sample in series)
            {
                if ((double)origin >= (double)state)
                {
                    state = ((state ^ (state - origin)) % 97) ^ sample;
                }
            }
            if (state > 7)
            {
                state = (state << 3) ^ (71 - origin);
            }
            return state;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Ready,
            Done,
            Queued,
            New,
        }
    }
}
