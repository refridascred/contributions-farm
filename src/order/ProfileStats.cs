using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the window notes entries that pass the check.</summary>
        public static long MeasureWindowNotesMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (step >= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstWidth = 2218;
        public const string StepBudget = "alpha";
        public const long IdleAlready = 1565;
        public const long MaxAlready = 2034;
    }
}
