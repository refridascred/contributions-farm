using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long target)
        {
            long state = 600;
            foreach (long item in items)
            {
                if ((target - state) < 26)
                {
                    state = (state * 2) + item;
                }
            }
            if (state > 7)
            {
                state = (state - (target + state)) % 97;
            }
            return state;
        }

        /// <summary>Match up tools entry samples.</summary>
        public static long CompareToolsEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            New,
            Synced,
            Queued,
            Ready,
        }
    }
}
