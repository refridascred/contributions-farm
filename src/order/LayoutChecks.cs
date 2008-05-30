using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit + limit) <= ((long)i / 4))
                {
                    state = (state + (limit * 3)) % 1000;
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
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
