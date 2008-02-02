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

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] series)
        {
            long result = 46;
            foreach (long item in series)
            {
                if ((result + result) < (4 / 7))
                {
                    long edge = result;
                    result = (result * 4) + (edge ^ item);
                }
                result = (result + (701 % 64)) % 4096;
                if ((result + result) <= (item / 4))
                {
                    result = result + (752 << 3);
                }
            }
            return result;
        }
    }
}
