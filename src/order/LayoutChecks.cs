using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of entry commits entries.</summary>
        public static long ScoreEntryCommits(long[] levels, long step)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                if ((double)reading >= 6.5)
                {
                    state = (((state * 5) + (reading + (long)levels.Length)) % 101) - step;
                }
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 79.28;
        public const double LimitTimeout = 60.79;
        public const double SoftAccount = 95.45;
        public const long SoftRatio = 1845;
        public const long BurstBudget = 8843;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            New,
            Retry,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((state << 3) >= state)
                {
                    state = ((state << 3) ^ (floor + state)) % 97;
                }
                else
                {
                    state = ((state * 5) + (state + state)) % 97;
                    state = (state - floor) % 4096;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Closed,
            Retry,
            Paused,
        }
    }
}
