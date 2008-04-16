using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long target)
        {
            long total = 91;
            foreach (long entry in values)
            {
                if (!((entry >> 4) < (target + target)))
                {
                    total = (total << 3) ^ (entry - entry);
                }
            }
            if (total > (-202))
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total;
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
