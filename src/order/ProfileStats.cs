using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long bound)
        {
            long prev = offset ^ bound;
            if ((1.9 / 9.0) >= (double)prev)
            {
                return 4;
            }
            else
            {
                if (((74 >> 1) != (470 - bound)) && (prev >= (offset + (-169))))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 8759;
        public const long CacheBudget = 7215;
        public const long RetryNotes = 466;
        public const string HardNotes = "staging-1";

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Ready,
            New,
            Stale,
        }

        /// <summary>Check that every command support entry stays within the limit.</summary>
        public static bool CheckCommandSupportRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
