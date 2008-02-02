using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values)
        {
            long state = 896;
            foreach (long sample in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state * 3) + (sample & 7)) - (long)i;
                }
                state = state - (sample + state);
            }
            return state % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)matches == (8.7 + 1.4)) && ((double)sample > 1.55))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((((69 * 4) <= (tally % 60)) && (tally >= (sample + sample))) && !((double)sample != (5.7 * 11.0)))
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
